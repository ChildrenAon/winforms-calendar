using System;

namespace WinFormsCalendar
{
    // [일정 한 개의 데이터]
    // 담을 값       : 날짜, 시작 시간·분, 제목, 메모, 카테고리, 첨부 파일 경로, D-day 표시 여부
    //                 (자세한 내용은 docs/설계.md 참고)
    // 사용하는 곳   : MainForm(목록 표시), ScheduleForm(입력), DataStore(저장·불러오기)
    // 참고 수업     : 5·7주차 get/set 프로퍼티 (LoginCheck)
    // 구분          : 필수 (일정 데이터의 바탕)
    // 담당          : ChildrenAon
    public class Schedule
    {
        public DateTime Date { get; set; }      // 날짜 (시·분은 아래에 따로 둔다)
        public int Hour { get; set; }           // 시작 시 (0~23)
        public int Minute { get; set; }         // 시작 분 (0~59)
        public String Title { get; set; }       // 제목
        public String Memo { get; set; }        // 메모
        public String Category { get; set; }    // 카테고리 이름 (색은 Category 클래스에 있다)
        public String AttachPath { get; set; }  // 첨부 파일 경로 (파일을 복사하지 않고 경로만 저장한다)
        public bool IsDday { get; set; }        // D-day 목록에 보일지 여부

        public Schedule()
        {
            Title = "";
            Memo = "";
            Category = "";
            AttachPath = "";
        }

        // 목록에 보여줄 시간 글자. 예) "09:30"
        public String TimeText
        {
            get { return Hour.ToString("00") + ":" + Minute.ToString("00"); }
        }

        // 수정 창에서 원본을 건드리지 않고 고치려고 값을 그대로 복사한 새 일정을 만든다
        public Schedule Copy()
        {
            Schedule s = new Schedule();
            s.Date = Date;
            s.Hour = Hour;
            s.Minute = Minute;
            s.Title = Title;
            s.Memo = Memo;
            s.Category = Category;
            s.AttachPath = AttachPath;
            s.IsDday = IsDday;
            return s;
        }
    }
}
