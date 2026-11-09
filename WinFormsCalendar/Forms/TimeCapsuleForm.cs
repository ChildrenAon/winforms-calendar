using System;
using System.Windows.Forms;

namespace WinFormsCalendar
{
    // [타임캡슐 메시지 창]
    // 하는 일   : 열어볼 날짜와 메시지를 저장해 두고, 그 날짜가 되면 팝업으로 보여준다.
    //             (일정 목록에는 표시하지 않는다)
    // 열리는 곳 : MainForm의 [타임캡슐] 버튼 (new TimeCapsuleForm(this) 로 모달 폼으로 연다),
    //             그리고 날짜가 되었을 때 자동으로
    // 참고 수업 : 9주차 Timer, 3주차 MessageBox, 6주차 파일 읽기·쓰기
    // 힌트      : 메시지 목록은 m_Parent.Capsules (Capsule 클래스: Date, Message, IsOpened) 에 담는다.
    //             새 메시지를 추가하거나 IsOpened 를 바꾼 뒤에는 m_Parent.SaveAll() 로 저장한다.
    //             "날짜가 되면 자동으로" 띄우는 부분은 MainForm 이 시작할 때 부를 함수를 이 파일에 만들어 두면 된다.
    // 구분      : 추가
    // 담당      : WhelkMono
    public partial class TimeCapsuleForm : Form
    {
        private MainForm m_Parent;      // 이 창을 연 메인 화면 (5주차 Form2(this) 방식)

        public TimeCapsuleForm()        // 디자이너가 폼을 그릴 때 쓰는 생성자
        {
            InitializeComponent();
        }

        public TimeCapsuleForm(MainForm parent) : this()
        {
            m_Parent = parent;
        }
    }
}
