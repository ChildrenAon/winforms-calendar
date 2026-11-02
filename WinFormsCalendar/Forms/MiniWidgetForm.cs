using System;
using System.Windows.Forms;

namespace WinFormsCalendar
{
    // [미니 위젯 모드 창]
    // 하는 일   : 달력을 작은 창으로 화면 구석에 항상 위에 띄운다.
    // 열리는 곳 : MainForm의 [미니 모드] 버튼
    // 참고 수업 : 4주차 Location·Size 조절, 7주차 메뉴
    //             TopMost, FormBorderStyle 속성은 수업에 없으므로 발표 때 따로 설명한다.
    // 담당      : (미정)
    public partial class MiniWidgetForm : Form
    {
        public MiniWidgetForm()
        {
            InitializeComponent();
        }
    }
}
