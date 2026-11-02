using System;
using System.Windows.Forms;

namespace WinFormsCalendar
{
    // [메인 화면 - 달력]
    // 하는 일   : 월 단위 달력을 보여주고 오늘 날짜 표시, 월 이동을 한다.
    //             날짜를 고르면 그날의 일정 목록을 보여주고, 다른 창(일정·검색·타임캡슐·잔디·미니 위젯)을 여는 출발점이다.
    // 열리는 곳 : 프로그램을 실행하면 Program.cs가 가장 먼저 띄운다.
    // 참고 수업 : 4주차 Location·BackColor·Color.FromArgb, 9주차 ListView
    //             달력 날짜 계산(DateTime)은 수업에 없으므로 발표 때 따로 설명한다.
    // 주의      : 여러 사람이 동시에 고치면 충돌이 나므로, 이 파일에 창을 여는 코드를 넣을 때는 미리 알린다.
    // 담당      : ChildrenAon
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
    }
}
