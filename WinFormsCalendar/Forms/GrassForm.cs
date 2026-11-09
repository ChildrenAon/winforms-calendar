using System;
using System.Windows.Forms;

namespace WinFormsCalendar
{
    // [잔디 기록 창]
    // 하는 일   : 날짜별로 활동(공부, 운동 등)과 시간(분)을 기록한다.
    //             기록한 시간이 길수록 달력 칸의 배경색이 진해진다.
    //             (칸 색을 계산해서 칠하는 부분은 MainForm에서 이미 한다. 이 창은 기록만 입력받으면 된다)
    // 열리는 곳 : MainForm의 [잔디 기록] 버튼 (new GrassForm(this) 로 모달 폼으로 연다)
    // 참고 수업 : 9주차 NumericUpDown, 4주차 Color.FromArgb로 색 만들기
    // 힌트      : 기록 목록은 m_Parent.GrassRecords (GrassRecord 클래스: Date, Activity, Minutes) 에 담는다.
    //             기록을 추가한 뒤 m_Parent.SaveAll() 로 저장하면, 창을 닫을 때 MainForm 이 달력 색을 다시 칠한다.
    //             날짜는 m_Parent.SelectedDate (달력에서 고른 날짜) 를 기본값으로 쓰면 편하다.
    // 구분      : 확장 (여유가 되면)
    // 담당      : WhelkMono
    public partial class GrassForm : Form
    {
        private MainForm m_Parent;      // 이 창을 연 메인 화면 (5주차 Form2(this) 방식)

        public GrassForm()              // 디자이너가 폼을 그릴 때 쓰는 생성자
        {
            InitializeComponent();
        }

        public GrassForm(MainForm parent) : this()
        {
            m_Parent = parent;
        }
    }
}
