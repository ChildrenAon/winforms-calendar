using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace WinFormsCalendar
{
    // [타임캡슐 메시지 창]
    // 하는 일   : 열어볼 날짜와 메시지를 저장해 두고, 그 날짜가 되면 팝업으로 보여준다.
    //             (일정 목록에는 표시하지 않는다)
    // 열리는 곳 : MainForm의 [타임캡슐] 버튼 (new TimeCapsuleForm(this) 로 모달 폼으로 연다),
    //             그리고 날짜가 되었을 때 자동으로
    // 참고 수업 : 9주차 Timer, 3주차 MessageBox, 6주차 파일 읽기·쓰기
    //             수업에 없는 것: DateTimePicker(날짜 고르기), DateTime 날짜 계산(남은 날 구하기),
    //                             코드로 Timer 만들기(new Timer, Tick += 로 이벤트 연결), static 변수·함수,
    //                             Application.OpenForms(열린 창 개수 확인),
    //                             DllImport·SendMessage(드롭다운 달력의 "오늘" 줄 숨기기)
    // 힌트      : 메시지 목록은 m_Parent.Capsules (Capsule 클래스: Date, Message, IsOpened) 에 담는다.
    //             새 메시지를 추가하거나 IsOpened 를 바꾼 뒤에는 m_Parent.SaveAll() 로 저장한다.
    //             "날짜가 되면 자동으로" 띄우는 부분은 MainForm 이 시작할 때 부를 함수를 이 파일에 만들어 두면 된다.
    // 구분      : 추가
    // 담당      : WhelkMono

    public partial class TimeCapsuleForm : Form
    {
        private MainForm m_Parent;      // 이 창을 연 메인 화면 (5주차 Form2(this) 방식)

        [DllImport("user32.dll")]
        private static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wParam, IntPtr lParam); // 수업에 없는 것

        public TimeCapsuleForm()        // 디자이너가 폼을 그릴 때 쓰는 생성자
        {
            InitializeComponent();
        }

        public TimeCapsuleForm(MainForm parent) : this()
        {
            m_Parent = parent;
            SendMessage(dtp_Date.Handle, 0x100B, IntPtr.Zero, (IntPtr)0x10);   // 드롭다운 달력에서 "오늘" 줄 숨기기
            dtp_Date.MinDate = DateTime.Today;      // 지난 날짜는 못 고르게 한다
            RefreshList();
        }

        // 묻어 둔 캡슐 목록을 다시 보여준다
        private void RefreshList()
        {
            lv_Capsule.Items.Clear();
            foreach (Capsule c in m_Parent.Capsules)
            {
                ListViewItem item = new ListViewItem(c.Date.ToString("yyyy-MM-dd"));

                if (c.IsOpened)
                {
                    item.SubItems.Add("열림");
                    item.SubItems.Add(c.Message);
                }
                else
                {
                    int nDays = (c.Date.Date - DateTime.Today).Days;

                    if (nDays == 0) item.SubItems.Add("오늘");
                    else item.SubItems.Add("D-" + nDays);

                    item.SubItems.Add("(아직 볼 수 없어요)");   // 열리기 전에는 내용을 가린다
                }

                item.Tag = c;       // 삭제할 때 어떤 캡슐인지 알려고 붙여 둔다
                lv_Capsule.Items.Add(item);
            }
        }

        // [묻기] 버튼
        private void bt_Add_Click(object sender, EventArgs e)
        {
            if (tb_Message.Text.Trim() == "")
            {
                MessageBox.Show("메시지를 입력해주세요.");
                return;
            }

            Capsule c = new Capsule();
            c.Date = dtp_Date.Value.Date;
            c.Message = tb_Message.Text.Trim();
            c.IsOpened = false;

            m_Parent.Capsules.Add(c);
            m_Parent.SaveAll();         // 파일에 저장

            tb_Message.Text = "";
            RefreshList();
        }

        // [삭제] 버튼
        private void bt_Delete_Click(object sender, EventArgs e)
        {
            if (lv_Capsule.SelectedItems.Count == 0)
            {
                MessageBox.Show("삭제할 캡슐을 선택해주세요.");
                return;
            }

            Capsule c = (Capsule)lv_Capsule.SelectedItems[0].Tag;
            m_Parent.Capsules.Remove(c);
            m_Parent.SaveAll();
            RefreshList();
        }

        // ───────── 날짜가 되면 자동으로 띄우기 (9주차 Timer) ─────────
        // MainForm 생성자 맨 끝에 TimeCapsuleForm.StartWatching(this); 한 줄을 넣는다.

        private static Timer s_Timer;
        private static MainForm s_Main;

        public static void StartWatching(MainForm parent)
        {
            s_Main = parent;
            s_Timer = new Timer();
            s_Timer.Interval = 1000;            // 1초마다 확인
            s_Timer.Tick += Timer_Tick;
            s_Timer.Start();
        }

        private static void Timer_Tick(object sender, EventArgs e)
        {
            if (Application.OpenForms.Count > 1) return;   // 다른 창이 열려 있으면 닫힐 때까지 기다린다

            s_Timer.Stop();                     // 팝업이 떠 있는 동안 또 확인하지 않게 멈춘다
            foreach (Capsule c in s_Main.Capsules)
            {
                if (c.IsOpened) continue;                   // 이미 본 건 넘어간다
                if (c.Date.Date > DateTime.Today) continue; // 아직 날짜가 안 된 건 넘어간다

                c.IsOpened = true;                          // 다시 안 뜨게 표시
                s_Main.SaveAll();
                MessageBox.Show(c.Message, "타임캡슐이 열렸어요! (" + c.Date.ToString("yyyy-MM-dd") + ")");
            }
            s_Timer.Start();
        }

        private void lv_Capsule_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;                                         // 바꾸려는 것을 취소
            e.NewWidth = lv_Capsule.Columns[e.ColumnIndex].Width;    // 원래 너비 그대로 유지
        }
    }
}