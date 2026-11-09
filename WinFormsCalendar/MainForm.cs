using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace WinFormsCalendar
{
    // [메인 화면 - 달력]
    // 하는 일   : 월 단위 달력을 보여주고 오늘 날짜 표시, 월 이동을 한다.
    //             날짜를 고르면 그날의 일정 목록을 보여주고, 다른 창(일정·검색·타임캡슐·잔디·미니 위젯)을 여는 출발점이다.
    //             달력 칸에는 일정이 있는 날의 카테고리 색 점, 잔디 기록이 있는 날의 진한 바탕색을 칠한다.
    // 열리는 곳 : 프로그램을 실행하면 Program.cs가 가장 먼저 띄운다.
    // 참고 수업 : 4주차 Location·BackColor·Color.FromArgb, 5주차 모달 폼(ShowDialog)·부모 폼 넘기기(Form2(this)),
    //             6주차 파일 읽기·쓰기, 3주차 MessageBox(YesNo), 9주차 ListView·ListBox
    //             수업에 없는 것: DateTime 날짜 계산, 달력 칸을 for 문으로 new Panel/Label 만들기,
    //                            List<T>, 목록 정렬(Sort) → 발표 때 따로 설명한다.
    // 주의      : 여러 사람이 동시에 고치면 충돌이 나므로, 이 파일에 창을 여는 코드를 넣을 때는 미리 알린다.
    // 구분      : 필수
    // 담당      : ChildrenAon
    public partial class MainForm : Form
    {
        // ───────── 데이터 (다른 창에서는 m_Parent.Schedules 처럼 꺼내 쓴다) ─────────
        private List<Schedule> m_listSchedules = new List<Schedule>();
        private List<Category> m_listCategories = new List<Category>();
        private List<Capsule> m_listCapsules = new List<Capsule>();
        private List<GrassRecord> m_listGrass = new List<GrassRecord>();

        public List<Schedule> Schedules { get { return m_listSchedules; } }
        public List<Category> Categories { get { return m_listCategories; } }
        public List<Capsule> Capsules { get { return m_listCapsules; } }
        public List<GrassRecord> GrassRecords { get { return m_listGrass; } }

        // ───────── 달력 상태 ─────────
        private DateTime m_dtMonth;       // 지금 보이는 달 (그 달 1일)
        private DateTime m_dtSelected;    // 선택한 날짜

        // 선택한 날짜 (다른 창에서 읽을 수 있다)
        public DateTime SelectedDate { get { return m_dtSelected; } }

        // ───────── 달력 칸 (6줄 x 7칸 = 42개) ─────────
        private const int GRID_X = 20;          // 달력 왼쪽 위 위치
        private const int GRID_Y = 80;
        private const int CELL_W = 96;          // 칸 크기
        private const int CELL_H = 80;
        private const int CELL_COUNT = 42;
        private const int DOT_MAX = 4;          // 한 칸에 찍는 일정 점의 최대 개수

        private Panel[] m_pnBorder = new Panel[CELL_COUNT];     // 칸 테두리 (선택하면 파란색)
        private Panel[] m_pnCell = new Panel[CELL_COUNT];       // 칸 바탕 (잔디 색을 칠하는 곳)
        private Label[] m_lbDay = new Label[CELL_COUNT];        // 날짜 숫자
        private Panel[] m_pnDotBar = new Panel[CELL_COUNT];     // 일정 점을 담는 흰 띠 (잔디 색이 진한 칸에서도 점이 잘 보이게)
        private Panel[,] m_pnDot = new Panel[CELL_COUNT, DOT_MAX];  // 일정 점
        private Label[] m_lbMore = new Label[CELL_COUNT];       // 점이 넘칠 때 "+2" 표시
        private DateTime[] m_dtCell = new DateTime[CELL_COUNT]; // 각 칸이 가리키는 날짜

        // ───────── 색과 글꼴 (4주차 Color.FromArgb) ─────────
        private static readonly Color COLOR_TEXT = Color.FromArgb(30, 43, 69);
        private static readonly Color COLOR_BLUE = Color.FromArgb(47, 95, 196);
        private static readonly Color COLOR_SUN = Color.FromArgb(214, 69, 65);
        private static readonly Color COLOR_OTHER_TEXT = Color.FromArgb(154, 163, 178);
        private static readonly Color COLOR_OTHER_BACK = Color.FromArgb(247, 248, 250);
        private static readonly Color COLOR_LINE = Color.FromArgb(225, 228, 234);
        private static readonly Color COLOR_CATEGORY_DEFAULT = Color.FromArgb(95, 105, 122);

        // 잔디 단계 색 (활동 시간이 길수록 진하다): 1시간 미만, 2시간 미만, 4시간 미만, 4시간 이상
        private static readonly Color[] COLOR_GRASS = {
            Color.FromArgb(200, 230, 201), Color.FromArgb(129, 199, 132),
            Color.FromArgb(67, 160, 71), Color.FromArgb(27, 94, 32) };

        private Font m_fontDay = new Font("맑은 고딕", 9F);
        private Font m_fontDayBold = new Font("맑은 고딕", 9F, FontStyle.Bold);
        private Font m_fontSmall = new Font("맑은 고딕", 8F);

        private static readonly String[] DAY_NAME = { "일", "월", "화", "수", "목", "금", "토" };

        public MainForm()
        {
            InitializeComponent();
            BuildCalendar();                // 달력 칸을 만든다

            // 저장해 둔 데이터를 읽어 온다. 카테고리가 하나도 없으면 기본 카테고리를 만든다.
            DataStore.Load(m_listSchedules, m_listCategories, m_listCapsules, m_listGrass);
            if (m_listCategories.Count == 0) AddDefaultCategories();

            m_dtSelected = DateTime.Today;
            m_dtMonth = new DateTime(m_dtSelected.Year, m_dtSelected.Month, 1);
            RefreshAll();
        }

        // ───────── 다른 창에서 쓰는 함수 ─────────

        // 지금 데이터를 파일에 저장한다. (데이터를 고친 창은 닫기 전에 이 함수를 부른다)
        public void SaveAll()
        {
            DataStore.Save(m_listSchedules, m_listCategories, m_listCapsules, m_listGrass);
        }

        // 달력·일정 목록·D-day를 모두 다시 그린다. (데이터를 고친 뒤에 부른다)
        public void RefreshAll()
        {
            RefreshCalendar();
            RefreshScheduleList();
            RefreshDday();
        }

        // 선택한 날짜를 바꾸고 그 날짜가 있는 달로 이동한다
        public void GoToDate(DateTime dt)
        {
            m_dtSelected = dt.Date;
            m_dtMonth = new DateTime(dt.Year, dt.Month, 1);
            RefreshAll();
        }

        // "2026-11-02 (월)" 모양의 글자로 바꾼다
        public static String DateToText(DateTime dt)
        {
            return dt.ToString("yyyy-MM-dd") + " (" + DAY_NAME[(int)dt.DayOfWeek] + ")";
        }

        // ───────── 달력 칸 만들기 ─────────
        // 달력 칸은 디자이너로 42개를 놓기 어려워서 for 문으로 만든다.
        // (수업 7주차 Form2 생성자에서 MouseWheel 이벤트를 += 로 연결한 것과 같은 방식으로 클릭 이벤트를 연결한다)
        private void BuildCalendar()
        {
            // 요일 줄
            for (int i = 0; i < 7; i++)
            {
                Label lbWeek = new Label();
                lbWeek.Text = DAY_NAME[i];
                lbWeek.AutoSize = false;
                lbWeek.TextAlign = ContentAlignment.MiddleCenter;
                lbWeek.Location = new Point(GRID_X + i * CELL_W, GRID_Y - 24);
                lbWeek.Size = new Size(CELL_W, 22);
                if (i == 0) lbWeek.ForeColor = COLOR_SUN;
                else if (i == 6) lbWeek.ForeColor = COLOR_BLUE;
                else lbWeek.ForeColor = COLOR_TEXT;
                this.Controls.Add(lbWeek);
            }

            // 날짜 칸
            for (int i = 0; i < CELL_COUNT; i++)
            {
                int nRow = i / 7;
                int nCol = i % 7;

                // 바깥 테두리 칸
                m_pnBorder[i] = new Panel();
                m_pnBorder[i].Location = new Point(GRID_X + nCol * CELL_W, GRID_Y + nRow * CELL_H);
                m_pnBorder[i].Size = new Size(CELL_W, CELL_H);
                m_pnBorder[i].BackColor = COLOR_LINE;
                this.Controls.Add(m_pnBorder[i]);

                // 안쪽 바탕 칸
                m_pnCell[i] = new Panel();
                m_pnCell[i].Location = new Point(1, 1);
                m_pnCell[i].Size = new Size(CELL_W - 2, CELL_H - 2);
                m_pnCell[i].BackColor = Color.White;
                m_pnCell[i].Tag = i;
                m_pnCell[i].Click += new EventHandler(Cell_Click);
                m_pnCell[i].DoubleClick += new EventHandler(Cell_DoubleClick);
                m_pnBorder[i].Controls.Add(m_pnCell[i]);

                // 날짜 숫자
                m_lbDay[i] = new Label();
                m_lbDay[i].AutoSize = true;
                m_lbDay[i].Padding = new Padding(3, 1, 3, 1);
                m_lbDay[i].Location = new Point(3, 3);
                m_lbDay[i].Tag = i;
                m_lbDay[i].Click += new EventHandler(Cell_Click);
                m_lbDay[i].DoubleClick += new EventHandler(Cell_DoubleClick);
                m_pnCell[i].Controls.Add(m_lbDay[i]);

                // 일정 점을 담는 흰 띠
                m_pnDotBar[i] = new Panel();
                m_pnDotBar[i].Location = new Point(4, CELL_H - 26);
                m_pnDotBar[i].Size = new Size(CELL_W - 12, 16);
                m_pnDotBar[i].BackColor = Color.White;
                m_pnDotBar[i].Visible = false;
                m_pnDotBar[i].Tag = i;
                m_pnDotBar[i].Click += new EventHandler(Cell_Click);
                m_pnDotBar[i].DoubleClick += new EventHandler(Cell_DoubleClick);
                m_pnCell[i].Controls.Add(m_pnDotBar[i]);

                // 일정 점 (최대 4개, 흰 띠 안에 놓는다)
                for (int k = 0; k < DOT_MAX; k++)
                {
                    m_pnDot[i, k] = new Panel();
                    m_pnDot[i, k].Size = new Size(9, 9);
                    m_pnDot[i, k].Location = new Point(4 + k * 13, 3);
                    m_pnDot[i, k].Visible = false;
                    m_pnDot[i, k].Tag = i;
                    m_pnDot[i, k].Click += new EventHandler(Cell_Click);
                    m_pnDot[i, k].DoubleClick += new EventHandler(Cell_DoubleClick);
                    m_pnDotBar[i].Controls.Add(m_pnDot[i, k]);
                }

                // 점이 넘칠 때 "+2" 표시
                m_lbMore[i] = new Label();
                m_lbMore[i].AutoSize = true;
                m_lbMore[i].Font = m_fontSmall;
                m_lbMore[i].ForeColor = COLOR_OTHER_TEXT;
                m_lbMore[i].BackColor = Color.White;
                m_lbMore[i].Location = new Point(56, 1);
                m_lbMore[i].Visible = false;
                m_lbMore[i].Tag = i;
                m_lbMore[i].Click += new EventHandler(Cell_Click);
                m_lbMore[i].DoubleClick += new EventHandler(Cell_DoubleClick);
                m_pnDotBar[i].Controls.Add(m_lbMore[i]);
            }
        }

        // 기본 카테고리 (처음 실행했을 때만 만든다. 색은 일정 창에서 바꿀 수 있다)
        private void AddDefaultCategories()
        {
            m_listCategories.Add(new Category("기본", Color.FromArgb(95, 105, 122)));
            m_listCategories.Add(new Category("학업", Color.FromArgb(47, 95, 196)));
            m_listCategories.Add(new Category("약속", Color.FromArgb(46, 139, 87)));
            m_listCategories.Add(new Category("운동", Color.FromArgb(230, 126, 34)));
            m_listCategories.Add(new Category("기타", Color.FromArgb(142, 68, 173)));
        }

        // ───────── 데이터 꺼내기 ─────────

        // 카테고리 이름으로 색을 찾는다. 없으면 기본 회색.
        private Color GetCategoryColor(String strName)
        {
            foreach (Category c in m_listCategories)
            {
                if (c.Name == strName) return c.Color;
            }
            return COLOR_CATEGORY_DEFAULT;
        }

        // 그날의 일정을 시간 순서로 모아서 돌려준다
        private List<Schedule> GetSchedules(DateTime dt)
        {
            List<Schedule> list = new List<Schedule>();
            foreach (Schedule s in m_listSchedules)
            {
                if (s.Date.Date == dt.Date) list.Add(s);
            }
            list.Sort(CompareSchedule);     // 수업에 없는 문법: 정렬 규칙을 함수로 넘긴다
            return list;
        }

        // 시간이 빠른 일정이 먼저 오게 비교한다. 시간이 같으면 제목 순서.
        private static int CompareSchedule(Schedule a, Schedule b)
        {
            int n = (a.Hour * 60 + a.Minute) - (b.Hour * 60 + b.Minute);
            if (n != 0) return n;
            return String.Compare(a.Title, b.Title);
        }

        // 날짜가 빠른 일정이 먼저 오게 비교한다 (D-day 목록용)
        private static int CompareByDate(Schedule a, Schedule b)
        {
            int n = a.Date.CompareTo(b.Date);
            if (n != 0) return n;
            return CompareSchedule(a, b);
        }

        // 그날 잔디 기록의 활동 시간(분)을 모두 더한다
        public int GetGrassMinutes(DateTime dt)
        {
            int nSum = 0;
            foreach (GrassRecord g in m_listGrass)
            {
                if (g.Date.Date == dt.Date) nSum += g.Minutes;
            }
            return nSum;
        }

        // 활동 시간을 단계(0~4)로 바꾼다. 0이면 칠하지 않는다.
        public int GetGrassLevel(DateTime dt)
        {
            int nMin = GetGrassMinutes(dt);
            if (nMin <= 0) return 0;
            if (nMin < 60) return 1;
            if (nMin < 120) return 2;
            if (nMin < 240) return 3;
            return 4;
        }

        // 잔디 단계(1~4)에 해당하는 색. 0이면 흰색. (잔디 창의 색 단계 안내에서도 같은 색을 쓴다)
        public static Color GetGrassColor(int nLevel)
        {
            if (nLevel < 1 || nLevel > COLOR_GRASS.Length) return Color.White;
            return COLOR_GRASS[nLevel - 1];
        }

        private Schedule GetSelectedSchedule()
        {
            if (lv_Schedule.SelectedItems.Count == 0) return null;
            return (Schedule)lv_Schedule.SelectedItems[0].Tag;
        }

        // ───────── 화면 다시 그리기 ─────────

        // 달력 칸 42개를 지금 보이는 달에 맞게 다시 칠한다
        private void RefreshCalendar()
        {
            lb_Month.Text = m_dtMonth.Year + "년 " + m_dtMonth.Month + "월";

            // 1일이 무슨 요일인지 (일요일=0). 첫 칸은 그만큼 앞선 날짜부터 시작한다.
            int nOffset = (int)m_dtMonth.DayOfWeek;

            for (int i = 0; i < CELL_COUNT; i++)
            {
                DateTime dt = m_dtMonth.AddDays(i - nOffset);
                m_dtCell[i] = dt;

                bool blInMonth = (dt.Month == m_dtMonth.Month);
                bool blToday = (dt.Date == DateTime.Today);
                bool blSelected = (dt.Date == m_dtSelected.Date);

                // 칸 바탕: 잔디 기록이 있으면 단계 색, 없으면 흰색(다른 달은 연회색)
                int nLevel = GetGrassLevel(dt);
                Color colBack = blInMonth ? Color.White : COLOR_OTHER_BACK;
                if (nLevel > 0) colBack = COLOR_GRASS[nLevel - 1];
                m_pnCell[i].BackColor = colBack;

                // 선택한 칸은 테두리를 파랗게 하고 안쪽을 조금 줄인다
                if (blSelected)
                {
                    m_pnBorder[i].BackColor = COLOR_BLUE;
                    m_pnCell[i].Location = new Point(2, 2);
                    m_pnCell[i].Size = new Size(CELL_W - 4, CELL_H - 4);
                }
                else
                {
                    m_pnBorder[i].BackColor = COLOR_LINE;
                    m_pnCell[i].Location = new Point(1, 1);
                    m_pnCell[i].Size = new Size(CELL_W - 2, CELL_H - 2);
                }

                // 날짜 숫자: 오늘은 파란 바탕에 흰 글자
                Color colText = COLOR_TEXT;
                if (!blInMonth) colText = COLOR_OTHER_TEXT;
                else if (dt.DayOfWeek == DayOfWeek.Sunday) colText = COLOR_SUN;
                else if (dt.DayOfWeek == DayOfWeek.Saturday) colText = COLOR_BLUE;
                if (nLevel >= 3) colText = Color.White;     // 진한 바탕에서는 흰 글자

                m_lbDay[i].Text = dt.Day.ToString();
                if (blToday)
                {
                    m_lbDay[i].BackColor = COLOR_BLUE;
                    m_lbDay[i].ForeColor = Color.White;
                    m_lbDay[i].Font = m_fontDayBold;
                }
                else
                {
                    m_lbDay[i].BackColor = Color.Transparent;
                    m_lbDay[i].ForeColor = colText;
                    m_lbDay[i].Font = m_fontDay;
                }

                // 일정 점: 일정마다 그 카테고리 색 점을 최대 4개까지 찍는다
                List<Schedule> list = GetSchedules(dt);
                for (int k = 0; k < DOT_MAX; k++)
                {
                    if (k < list.Count)
                    {
                        m_pnDot[i, k].BackColor = GetCategoryColor(list[k].Category);
                        m_pnDot[i, k].Visible = true;
                    }
                    else
                    {
                        m_pnDot[i, k].Visible = false;
                    }
                }

                m_pnDotBar[i].Visible = (list.Count > 0);      // 일정이 있는 날만 흰 띠를 보인다

                if (list.Count > DOT_MAX)
                {
                    m_lbMore[i].Text = "+" + (list.Count - DOT_MAX);
                    m_lbMore[i].Visible = true;
                }
                else
                {
                    m_lbMore[i].Visible = false;
                }
            }
        }

        // 선택한 날짜의 일정을 오른쪽 목록에 보여준다
        private void RefreshScheduleList()
        {
            lb_SelectedDate.Text = DateToText(m_dtSelected);

            lv_Schedule.Items.Clear();
            foreach (Schedule s in GetSchedules(m_dtSelected))
            {
                ListViewItem item = new ListViewItem(s.TimeText);
                item.SubItems.Add(s.Title);
                item.SubItems.Add(s.Category);
                item.ForeColor = GetCategoryColor(s.Category);
                item.Tag = s;       // 수정·삭제할 때 어떤 일정인지 알려고 일정 자체를 붙여 둔다
                lv_Schedule.Items.Add(item);
            }
        }

        // D-day로 표시한 일정 중 오늘 이후의 것을 가까운 순서로 보여준다
        private void RefreshDday()
        {
            List<Schedule> list = new List<Schedule>();
            foreach (Schedule s in m_listSchedules)
            {
                if (s.IsDday && s.Date.Date >= DateTime.Today) list.Add(s);
            }
            list.Sort(CompareByDate);

            ls_Dday.Items.Clear();
            foreach (Schedule s in list)
            {
                int nDays = (s.Date.Date - DateTime.Today).Days;     // 오늘부터 며칠 남았는지
                String strDday = (nDays == 0) ? "D-Day" : "D-" + nDays;
                ls_Dday.Items.Add(strDday + "   " + s.Title + "  (" + s.Date.Month + "/" + s.Date.Day + ")");
            }
            if (ls_Dday.Items.Count == 0)
                ls_Dday.Items.Add("D-day로 표시한 일정이 없습니다.");
        }

        // ───────── 이벤트: 달력 ─────────

        private void bt_Prev_Click(object sender, EventArgs e)
        {
            m_dtMonth = m_dtMonth.AddMonths(-1);
            RefreshCalendar();
        }

        private void bt_Next_Click(object sender, EventArgs e)
        {
            m_dtMonth = m_dtMonth.AddMonths(1);
            RefreshCalendar();
        }

        private void bt_Today_Click(object sender, EventArgs e)
        {
            GoToDate(DateTime.Today);
        }

        // 날짜 칸을 한 번 누르면 그 날짜를 선택한다 (칸 안의 숫자·점을 눌러도 같다)
        private void Cell_Click(object sender, EventArgs e)
        {
            Control ctl = sender as Control;
            int nIndex = (int)ctl.Tag;      // 몇 번째 칸인지는 Tag에 넣어 두었다
            GoToDate(m_dtCell[nIndex]);
        }

        // 날짜 칸을 두 번 누르면 그 날짜에 일정을 추가하는 창을 연다
        // (바로 앞의 한 번 클릭으로 이미 그 날짜가 선택돼 있다)
        private void Cell_DoubleClick(object sender, EventArgs e)
        {
            OpenScheduleForm(null);
        }

        // ───────── 이벤트: 일정 추가·수정·삭제 ─────────

        private void bt_Add_Click(object sender, EventArgs e)
        {
            OpenScheduleForm(null);
        }

        private void bt_Edit_Click(object sender, EventArgs e)
        {
            Schedule s = GetSelectedSchedule();
            if (s == null)
            {
                MessageBox.Show("수정할 일정을 선택해주세요.");
                return;
            }
            OpenScheduleForm(s);
        }

        private void lv_Schedule_DoubleClick(object sender, EventArgs e)
        {
            bt_Edit_Click(sender, e);
        }

        private void bt_Delete_Click(object sender, EventArgs e)
        {
            Schedule s = GetSelectedSchedule();
            if (s == null)
            {
                MessageBox.Show("삭제할 일정을 선택해주세요.");
                return;
            }

            // 3주차 종료 확인(FormClosing)과 같은 방식으로 한 번 더 묻는다
            if (MessageBox.Show("'" + s.Title + "' 일정을 삭제하시겠습니까?", "삭제 확인", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                m_listSchedules.Remove(s);
                SaveAll();
                RefreshAll();
            }
        }

        // 일정 등록·수정 창을 모달로 연다. 새 일정이면 target 에 null 을 넣는다.
        // (5주차 Form2(this) 처럼 이 폼(this)을 창에 넘기고, 결과는 창의 Result 프로퍼티로 받는다)
        private void OpenScheduleForm(Schedule target)
        {
            ScheduleForm _ScheduleForm = new ScheduleForm(this, target, m_dtSelected);
            if (_ScheduleForm.ShowDialog() == DialogResult.OK)
            {
                if (target == null)
                {
                    m_listSchedules.Add(_ScheduleForm.Result);
                }
                else
                {
                    int nIndex = m_listSchedules.IndexOf(target);
                    m_listSchedules[nIndex] = _ScheduleForm.Result;
                }
                SaveAll();
            }
            RefreshAll();       // 창 안에서 카테고리 색을 바꿨을 수도 있어서 취소해도 다시 그린다
        }

        // ───────── 이벤트: 다른 창 열기 (창 안의 내용은 각자 맡은 사람이 채운다) ─────────

        private void bt_Search_Click(object sender, EventArgs e)
        {
            SearchForm _SearchForm = new SearchForm(this);
            _SearchForm.ShowDialog();
            RefreshAll();
        }

        private void bt_Capsule_Click(object sender, EventArgs e)
        {
            TimeCapsuleForm _TimeCapsuleForm = new TimeCapsuleForm(this);
            _TimeCapsuleForm.ShowDialog();
            RefreshAll();
        }

        private void bt_Grass_Click(object sender, EventArgs e)
        {
            GrassForm _GrassForm = new GrassForm(this);
            _GrassForm.ShowDialog();
            RefreshAll();
        }

        private void bt_Mini_Click(object sender, EventArgs e)
        {
            MiniWidgetForm _MiniWidgetForm = new MiniWidgetForm(this);
            _MiniWidgetForm.ShowDialog();
            RefreshAll();
        }
    }
}
