using System;
using System.Windows.Forms;

namespace WinFormsCalendar
{
    // [미니 위젯 모드 창]
    // 하는 일   : 달력을 작은 창으로 화면 구석에 항상 위에 띄운다.
    // 열리는 곳 : MainForm의 [미니 모드] 버튼 (new MiniWidgetForm(this) 로 모달 폼으로 연다)
    // 참고 수업 : 4주차 Location·Size 조절, 7주차 메뉴
    //             TopMost, FormBorderStyle 속성은 수업에 없으므로 발표 때 따로 설명한다.
    // 힌트      : 오늘의 일정은 m_Parent.Schedules 에서 s.Date == DateTime.Today 인 것을 골라 보여주면 된다.
    //             위젯이 떠 있는 동안 메인 화면을 숨기려면 이 창이 열릴 때 m_Parent.Hide(),
    //             닫힐 때 m_Parent.Show() 를 부르면 된다. (MainForm 을 고칠 필요는 없다)
    // 구분      : 확장 (여유가 되면)
    // 담당      : WhelkMono
    public partial class MiniWidgetForm : Form
    {
        private MainForm m_Parent;      // 이 창을 연 메인 화면 (5주차 Form2(this) 방식)

        public MiniWidgetForm()         // 디자이너가 폼을 그릴 때 쓰는 생성자
        {
            InitializeComponent();
        }

        public MiniWidgetForm(MainForm parent) : this()
        {
            m_Parent = parent;
        }
    }
}
