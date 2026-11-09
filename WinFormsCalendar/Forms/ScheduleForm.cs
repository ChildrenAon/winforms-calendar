using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace WinFormsCalendar
{
    // [일정 등록·수정 창]
    // 하는 일   : 날짜별 일정의 제목, 시간·분, 메모, 카테고리(색), 첨부 파일, D-day 표시 여부를 입력받는다.
    // 열리는 곳 : MainForm에서 [추가]/[수정] 버튼을 누르면 모달 폼으로 열린다.
    // 참고 수업 : 5주차 모달 폼·값 전달(Form2(this), 프로퍼티로 결과 돌려주기), 5주차 ListBox·ComboBox,
    //             6주차 파일·색 대화상자(OpenFileDialog, ColorDialog), 9주차 NumericUpDown, 4주차 CheckBox
    // 구분      : 필수(등록·수정·삭제) · 추가(시간/분, 파일 첨부) · 확장(카테고리 색, D-day)
    // 담당      : ChildrenAon
    public partial class ScheduleForm : Form
    {
        private MainForm m_Parent;          // 이 창을 연 메인 화면 (카테고리 목록을 여기서 꺼내 쓴다)
        private DateTime m_dtDate;          // 일정의 날짜 (이 창에서는 바꾸지 않는다)
        private String m_strAttach = "";    // 첨부 파일 경로

        // [확인]을 누르면 입력한 값이 여기에 담긴다. 메인 화면이 읽어 간다.
        // (5·7주차의 LoginCheck 처럼 프로퍼티로 값을 돌려준다)
        public Schedule Result { get; private set; }

        public ScheduleForm()           // 디자이너가 폼을 그릴 때 쓰는 생성자
        {
            InitializeComponent();
        }

        // parent: 메인 화면, schedule: 수정할 일정(새 일정이면 null), dtDate: 새 일정의 날짜
        public ScheduleForm(MainForm parent, Schedule schedule, DateTime dtDate) : this()
        {
            m_Parent = parent;
            FillCategory();

            if (schedule == null)
            {
                this.Text = "일정 등록";
                m_dtDate = dtDate.Date;
                nu_Hour.Value = 9;
                nu_Minute.Value = 0;
            }
            else
            {
                this.Text = "일정 수정";
                m_dtDate = schedule.Date.Date;
                tb_Title.Text = schedule.Title;
                nu_Hour.Value = schedule.Hour;
                nu_Minute.Value = schedule.Minute;
                tb_Memo.Text = schedule.Memo;
                m_strAttach = schedule.AttachPath;
                ck_Dday.Checked = schedule.IsDday;

                // 저장된 카테고리 이름과 같은 항목을 고른다
                int nIndex = cb_Category.Items.IndexOf(schedule.Category);
                if (nIndex >= 0) cb_Category.SelectedIndex = nIndex;
            }

            lb_Date.Text = MainForm.DateToText(m_dtDate);
            ShowAttach();
        }

        // 분류 콤보박스에 메인 화면의 카테고리 이름을 채운다 (5주차 ComboBox.Items.Add)
        private void FillCategory()
        {
            cb_Category.Items.Clear();
            foreach (Category c in m_Parent.Categories)
            {
                cb_Category.Items.Add(c.Name);
            }
            if (cb_Category.Items.Count > 0) cb_Category.SelectedIndex = 0;
        }

        // 콤보박스에서 고른 카테고리 (없으면 null)
        private Category GetSelectedCategory()
        {
            int nIndex = cb_Category.SelectedIndex;
            if (nIndex < 0) return null;
            return m_Parent.Categories[nIndex];
        }

        // 첨부 파일 이름을 화면에 보여준다 (경로가 길어서 파일 이름만 보인다)
        private void ShowAttach()
        {
            if (m_strAttach == "") lb_Attach.Text = "첨부 파일 없음";
            else
            {
                try { lb_Attach.Text = Path.GetFileName(m_strAttach); }
                catch (Exception) { lb_Attach.Text = m_strAttach; }    // 경로에 쓸 수 없는 글자가 있으면 그대로 보여준다
                finally { }
            }
        }

        // 분류를 바꾸면 그 카테고리의 색을 옆 네모에 보여준다
        private void cb_Category_SelectedIndexChanged(object sender, EventArgs e)
        {
            Category c = GetSelectedCategory();
            if (c != null) pn_CategoryColor.BackColor = c.Color;
        }

        // 선택한 카테고리의 색을 바꾼다 (6주차 ColorDialog)
        private void bt_CategoryColor_Click(object sender, EventArgs e)
        {
            Category c = GetSelectedCategory();
            if (c == null) return;

            colorDialog1.Color = c.Color;
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                c.Color = colorDialog1.Color;
                pn_CategoryColor.BackColor = c.Color;
                m_Parent.SaveAll();     // 일정을 저장하지 않고 취소해도 색은 바로 저장해 둔다
            }
        }

        // 첨부할 파일을 고른다 (6주차 OpenFileDialog)
        private void bt_Attach_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "모든 파일(*.*)|*.*";
            openFileDialog1.RestoreDirectory = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                m_strAttach = openFileDialog1.FileName;
                ShowAttach();
            }
        }

        private void bt_AttachClear_Click(object sender, EventArgs e)
        {
            m_strAttach = "";
            ShowAttach();
        }

        // [확인]: 입력값을 확인하고 Result 에 담은 뒤 창을 닫는다
        private void bt_OK_Click(object sender, EventArgs e)
        {
            String strTitle = tb_Title.Text.Trim();
            if (strTitle == "")
            {
                MessageBox.Show("제목을 입력해주세요.");
                tb_Title.Focus();
                return;
            }

            Schedule s = new Schedule();
            s.Date = m_dtDate;
            s.Hour = (int)nu_Hour.Value;
            s.Minute = (int)nu_Minute.Value;
            s.Title = strTitle;
            s.Memo = tb_Memo.Text;
            if (cb_Category.SelectedItem != null) s.Category = cb_Category.SelectedItem.ToString();
            s.AttachPath = m_strAttach;
            s.IsDday = ck_Dday.Checked;

            Result = s;
            this.DialogResult = DialogResult.OK;    // 모달 폼은 DialogResult 를 정하면 닫히고, ShowDialog()가 이 값을 돌려준다
        }
    }
}
