using System;
using System.Windows.Forms;

namespace WinFormsCalendar
{
    // [타임캡슐 메시지 창]
    // 하는 일   : 열어볼 날짜와 메시지를 저장해 두고, 그 날짜가 되면 팝업으로 보여준다.
    //             (일정 목록에는 표시하지 않는다)
    // 열리는 곳 : MainForm의 [타임캡슐] 버튼, 그리고 날짜가 되었을 때 자동으로
    // 참고 수업 : 9주차 Timer, 3주차 MessageBox, 6주차 파일 읽기·쓰기
    // 구분      : 추가
    // 담당      : WhelkMono
    public partial class TimeCapsuleForm : Form
    {
        public TimeCapsuleForm()
        {
            InitializeComponent();
        }
    }
}
