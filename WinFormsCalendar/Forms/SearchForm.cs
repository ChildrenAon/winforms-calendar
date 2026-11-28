using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WinFormsCalendar
{
    // [일정 검색 창]
    // 하는 일   : 키워드를 입력하면 제목·메모에 그 키워드가 들어간 일정을 찾아 목록으로 보여준다.
    //             결과는 날짜·시간 순서이고, 영어 대문자와 소문자는 구분하지 않는다.
    //             결과를 두 번 누르면 메인 화면 달력이 그 날짜로 이동하고 검색 창이 닫힌다.
    // 열리는 곳 : MainForm의 [검색] 버튼 (new SearchForm(this) 로 모달 폼으로 연다)
    // 참고 수업 : 6장 ListView, 3장 TextBox, 4장 MessageBox, 5장 DoubleClick 이벤트, 2장 Tag
    //             수업에 없는 것: IndexOf(글자가 들어 있는지 대소문자 구분 없이 확인), Trim(앞뒤 빈칸 지우기),
    //                             List<T>와 foreach(일정 목록 돌기), Sort(날짜순 정렬),
    //                             ColumnWidthChanging(열 너비 고정)
    // 구분      : 확장 (여유가 되면)
    // 담당      : WhelkMono

    public partial class SearchForm : Form
    {
        private MainForm m_Parent;

        public SearchForm()             // 디자이너가 폼을 그릴 때 쓰는 생성자
        {
            InitializeComponent();
        }

        public SearchForm(MainForm parent) : this()
        {
            m_Parent = parent;
        }

        // [검색] 버튼: 제목이나 메모에 키워드가 들어간 일정을 찾아 목록에 보여준다
        private void bt_Search_Click(object sender, EventArgs e)
        {
            String strKeyword = tb_Keyword.Text.Trim();
            if (strKeyword == "")
            {
                MessageBox.Show("검색할 키워드를 입력해주세요.");
                tb_Keyword.Focus();
                return;
            }

            // 키워드가 들어간 일정을 먼저 모은 뒤, 날짜와 시간 순서로 정렬한다
            List<Schedule> list = new List<Schedule>();
            foreach (Schedule s in m_Parent.Schedules)
            {
                if (HasKeyword(s.Title, strKeyword) || HasKeyword(s.Memo, strKeyword))
                    list.Add(s);
            }
            list.Sort(MainForm.CompareByDate);      // 메인 화면의 D-day 목록과 같은 정렬 규칙

            lv_Result.Items.Clear();
            foreach (Schedule s in list)
            {
                ListViewItem item = new ListViewItem(s.Date.ToString("yyyy-MM-dd"));
                item.SubItems.Add(s.TimeText);      // "09:30" 모양 (Schedule에 이미 있다)
                item.SubItems.Add(s.Title);
                item.Tag = s;                       // 두 번 눌렀을 때 어떤 일정인지 알려고 붙여 둔다
                lv_Result.Items.Add(item);
            }

            lb_Count.Text = "검색 결과 " + lv_Result.Items.Count + "개";
            if (lv_Result.Items.Count == 0)
                MessageBox.Show("'" + strKeyword + "'(이)가 들어간 일정이 없습니다.");
        }

        // 글자에 키워드가 들어 있는지 확인한다. 영어 대소문자는 구분하지 않는다. (ppt 로 PPT 도 찾는다)
        private bool HasKeyword(String strText, String strKeyword)
        {
            return strText.IndexOf(strKeyword, StringComparison.OrdinalIgnoreCase) >= 0;
        }

        // 결과를 두 번 누르면: 메인 화면 달력을 그 날짜로 옮기고 검색 창을 닫는다
        private void lv_Result_DoubleClick(object sender, EventArgs e)
        {
            if (lv_Result.SelectedItems.Count == 0) return;

            Schedule s = (Schedule)lv_Result.SelectedItems[0].Tag;
            m_Parent.GoToDate(s.Date);
            this.Close();
        }

        // 실행 중에 열 너비를 바꾸지 못하게 막는다
        private void lv_Result_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = lv_Result.Columns[e.ColumnIndex].Width;
        }
    }
}