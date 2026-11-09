using System;
using System.Windows.Forms;

namespace WinFormsCalendar
{
    // [잔디 기록 창]
    // 하는 일   : 날짜별로 활동(공부, 운동 등)과 시간(분)을 기록한다.
    //             기록한 시간이 길수록 달력 칸의 배경색이 진해진다. (칸 색을 칠하는 부분은 MainForm에 있다)
    // 열리는 곳 : MainForm의 [잔디 기록] 버튼 (new GrassForm(this) 로 모달 폼으로 연다)
    // 참고 수업 : 5주차 모달 폼·부모 폼 넘기기(Form2(this)), 9주차 NumericUpDown·ListView,
    //             3주차 MessageBox, 4주차 Color.FromArgb로 색 만들기
    // 구분      : 확장
    // 담당      : ChildrenAon
    public partial class GrassForm : Form
    {
        private MainForm m_Parent;          // 이 창을 연 메인 화면 (기록 목록은 여기서 꺼내 쓴다)
        private DateTime m_dtDate;          // 기록할 날짜 (달력에서 고른 날짜. 다른 날은 달력에서 고르고 다시 연다)

        public GrassForm()                  // 디자이너가 폼을 그릴 때 쓰는 생성자
        {
            InitializeComponent();
        }

        public GrassForm(MainForm parent) : this()
        {
            m_Parent = parent;
            m_dtDate = m_Parent.SelectedDate.Date;
            lb_Date.Text = MainForm.DateToText(m_dtDate);

            // 색 단계 안내: 메인 화면 달력에 칠해지는 색과 똑같은 색을 보여준다
            pn_Legend1.BackColor = MainForm.GetGrassColor(1);
            pn_Legend2.BackColor = MainForm.GetGrassColor(2);
            pn_Legend3.BackColor = MainForm.GetGrassColor(3);
            pn_Legend4.BackColor = MainForm.GetGrassColor(4);

            RefreshRecords();
        }

        // 그날의 기록 목록과 합계를 다시 보여준다
        private void RefreshRecords()
        {
            lv_Record.Items.Clear();
            foreach (GrassRecord g in m_Parent.GrassRecords)
            {
                if (g.Date.Date != m_dtDate) continue;

                ListViewItem item = new ListViewItem(g.Activity);
                item.SubItems.Add(g.Minutes.ToString());
                item.Tag = g;           // 삭제할 때 어떤 기록인지 알려고 기록 자체를 붙여 둔다
                lv_Record.Items.Add(item);
            }

            // 합계(분)와 달력에 칠해지는 단계 (단계 계산은 메인 화면의 함수를 그대로 쓴다)
            int nTotal = m_Parent.GetGrassMinutes(m_dtDate);
            int nLevel = m_Parent.GetGrassLevel(m_dtDate);

            String strTotal = "합계 " + nTotal + "분";
            if (nTotal >= 60) strTotal += " (" + (nTotal / 60) + "시간 " + (nTotal % 60) + "분)";
            if (nLevel > 0) strTotal += "  ·  " + nLevel + "단계";
            lb_Total.Text = strTotal;
        }

        // [기록 추가]: 입력한 활동과 시간을 기록 목록에 넣고 바로 저장한다
        private void bt_Add_Click(object sender, EventArgs e)
        {
            String strActivity = tb_Activity.Text.Trim();
            if (strActivity == "")
            {
                MessageBox.Show("활동 이름을 입력해주세요.");
                tb_Activity.Focus();
                return;
            }

            GrassRecord g = new GrassRecord();
            g.Date = m_dtDate;
            g.Activity = strActivity;
            g.Minutes = (int)nu_Minutes.Value;

            m_Parent.GrassRecords.Add(g);
            m_Parent.SaveAll();             // 파일에 저장
            m_Parent.RefreshAll();          // 뒤에 보이는 달력의 칸 색도 바로 바꾼다
            RefreshRecords();

            tb_Activity.Text = "";          // 다음 기록을 바로 입력할 수 있게 비우고 커서를 옮긴다
            tb_Activity.Focus();
        }

        // [선택 삭제]: 목록에서 고른 기록을 지운다
        private void bt_Delete_Click(object sender, EventArgs e)
        {
            if (lv_Record.SelectedItems.Count == 0)
            {
                MessageBox.Show("삭제할 기록을 선택해주세요.");
                return;
            }

            GrassRecord g = (GrassRecord)lv_Record.SelectedItems[0].Tag;
            m_Parent.GrassRecords.Remove(g);
            m_Parent.SaveAll();
            m_Parent.RefreshAll();
            RefreshRecords();
        }
    }
}
