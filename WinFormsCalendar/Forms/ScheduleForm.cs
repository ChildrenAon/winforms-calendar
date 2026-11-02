using System;
using System.Windows.Forms;

namespace WinFormsCalendar
{
    // [일정 등록·수정 창]
    // 하는 일   : 날짜별 일정의 제목, 시간·분, 메모, 카테고리(색), 첨부 파일, D-day 표시 여부를 입력받는다.
    // 열리는 곳 : MainForm에서 [추가]/[수정] 버튼을 누르면 모달 폼으로 열린다.
    // 참고 수업 : 5주차 모달 폼·값 전달, 5주차 ListBox·ComboBox,
    //             6주차 파일·색 대화상자, 9주차 NumericUpDown
    // 담당      : (미정)
    public partial class ScheduleForm : Form
    {
        public ScheduleForm()
        {
            InitializeComponent();
        }
    }
}
