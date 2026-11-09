using System;
using System.Windows.Forms;

namespace WinFormsCalendar
{
    // [잔디 기록 창]
    // 하는 일   : 날짜별로 활동(공부, 운동 등)과 시간(분)을 기록한다.
    //             기록한 시간이 길수록 달력 칸의 배경색이 진해진다.
    //             (칸 색을 계산해서 칠하는 부분은 MainForm에서 한다)
    // 열리는 곳 : MainForm의 [잔디] 버튼
    // 참고 수업 : 9주차 NumericUpDown, 4주차 Color.FromArgb로 색 만들기
    // 구분      : 확장 (여유가 되면)
    // 담당      : WhelkMono
    public partial class GrassForm : Form
    {
        public GrassForm()
        {
            InitializeComponent();
        }
    }
}
