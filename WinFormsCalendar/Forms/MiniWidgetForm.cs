using System;
using System.Drawing;
using System.Windows.Forms;

namespace WinFormsCalendar
{
    // [미니 위젯 모드 창]
    // 하는 일   : 오늘 날짜와 오늘 일정을 작은 창으로 화면 오른쪽 아래 구석에 항상 위에 띄운다.
    //             위젯이 떠 있는 동안 메인 화면은 숨기고, 위젯을 닫으면 메인 화면이 다시 나타난다.
    // 열리는 곳 : MainForm의 [미니 모드] 버튼 (new MiniWidgetForm(this) 로 모달 폼으로 연다)
    // 참고 수업 : 2장 Location·폼 이벤트(Load, FormClosed), 3장 ListBox, 5장 KeyDown
    //             수업에 없는 것: TopMost(항상 위), FormBorderStyle(크기를 바꿀 수 없는 창 테두리),
    //                             Screen.PrimaryScreen.WorkingArea(화면 크기 구하기)
    // 구분      : 확장 (여유가 되면)
    // 담당      : WhelkMono

    public partial class MiniWidgetForm : Form
    {
        private MainForm m_Parent;      // 이 창을 연 메인 화면

        public MiniWidgetForm()         // 디자이너가 폼을 그릴 때 쓰는 생성자
        {
            InitializeComponent();
        }

        public MiniWidgetForm(MainForm parent) : this()
        {
            m_Parent = parent;
        }

        // 창이 열릴 때: 메인 화면을 숨기고, 화면 오른쪽 아래 구석으로 옮기고, 오늘 일정을 보여준다
        private void MiniWidgetForm_Load(object sender, EventArgs e)
        {
            m_Parent.Hide();

            // 작업 표시줄을 뺀 화면 영역의 오른쪽 아래에서 20씩 띄운다
            Rectangle area = Screen.PrimaryScreen.WorkingArea;
            this.Location = new Point(area.Right - this.Width - 20, area.Bottom - this.Height - 20);

            lb_Today.Text = MainForm.DateToText(DateTime.Today);

            // 메인 화면의 GetSchedules 는 그날 일정을 시간 순서로 모아 돌려준다
            ls_Today.Items.Clear();
            foreach (Schedule s in m_Parent.GetSchedules(DateTime.Today))
            {
                ls_Today.Items.Add(s.TimeText + "   " + s.Title);
            }
            if (ls_Today.Items.Count == 0)
                ls_Today.Items.Add("오늘 일정이 없습니다.");

            // 가까운 D-day: D-day로 표시한 일정 중 오늘이거나 앞으로 올 것 중 가장 빠른 것 하나
            Schedule near = null;
            foreach (Schedule s in m_Parent.Schedules)
            {
                if (!s.IsDday) continue;                    // D-day로 표시 안 한 일정은 넘어간다
                if (s.Date.Date < DateTime.Today) continue; // 이미 지난 날은 넘어간다

                if (near == null || s.Date < near.Date)     // 지금까지 찾은 것보다 빠르면 바꾼다
                    near = s;
            }

            if (near == null)
            {
                lb_Dday.Text = "D-day 일정이 없습니다.";
            }
            else
            {
                int nDays = (near.Date.Date - DateTime.Today).Days;
                String strDday = (nDays == 0) ? "D-Day" : "D-" + nDays;
                lb_Dday.Text = strDday + "  " + near.Title;
            }

            // 오늘 잔디: 오늘 기록한 활동 시간(분) 합계 (계산은 메인 화면의 함수를 그대로 쓴다)
            int nMinutes = m_Parent.GetGrassMinutes(DateTime.Today);
            lb_Grass.Text = "오늘 활동 " + nMinutes + "분";

            int nLevel = m_Parent.GetGrassLevel(DateTime.Today);    // 0~4 단계
            pn_Grass.BackColor = MainForm.GetGrassColor(nLevel);
        }

        // 창이 닫힐 때: 숨겼던 메인 화면을 다시 보여준다
        private void MiniWidgetForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            m_Parent.Show();
        }

        // Esc 키를 누르면 닫는다
        private void MiniWidgetForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }
    }
}