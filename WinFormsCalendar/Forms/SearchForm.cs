using System;
using System.Windows.Forms;

namespace WinFormsCalendar
{
    // [일정 검색 창]
    // 하는 일   : 키워드를 입력하면 제목·메모에 그 키워드가 들어간 일정을 찾아 목록으로 보여준다.
    // 열리는 곳 : MainForm의 [검색] 버튼 (new SearchForm(this) 로 모달 폼으로 연다)
    // 참고 수업 : 9주차 ListView, 5주차 TextBox·ListBox
    // 힌트      : 일정 목록은 m_Parent.Schedules 로 꺼낸다.
    //               foreach (Schedule s in m_Parent.Schedules) { if (s.Title.Contains(strKeyword)) ... }
    //             결과를 골랐을 때 m_Parent.GoToDate(s.Date) 를 부르면 메인 화면이 그 날짜로 이동한다.
    // 구분      : 확장 (여유가 되면)
    // 담당      : WhelkMono
    public partial class SearchForm : Form
    {
        private MainForm m_Parent;      // 이 창을 연 메인 화면 (5주차 Form2(this) 방식)

        public SearchForm()             // 디자이너가 폼을 그릴 때 쓰는 생성자
        {
            InitializeComponent();
        }

        public SearchForm(MainForm parent) : this()
        {
            m_Parent = parent;
        }
    }
}
