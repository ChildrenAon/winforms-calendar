using System;
using System.Windows.Forms;

namespace WinFormsCalendar
{
    // [미니 위젯 모드 창]
    // 하는 일   : 달력을 작은 창으로 화면 구석에 항상 위에 띄운다.
    // 열리는 곳 : MainForm의 [미니 모드] 버튼
    // 참고 수업 : WEEK04_01(Location, Size 조절), WEEK07_01(메뉴)
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
