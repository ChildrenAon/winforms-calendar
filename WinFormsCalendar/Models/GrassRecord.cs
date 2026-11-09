using System;

namespace WinFormsCalendar
{
    // [잔디 기록 한 개의 데이터]
    // 담을 값       : 날짜, 활동 이름(공부·운동 등), 활동 시간(분)
    // 사용하는 곳   : GrassForm(기록 입력), MainForm(그날 시간을 모두 더해 달력 칸 색을 칠함), DataStore(저장)
    // 구분          : 확장 (잔디 심기)
    // 담당          : ChildrenAon
    public class GrassRecord
    {
        public DateTime Date { get; set; }      // 활동한 날짜
        public String Activity { get; set; }    // 활동 이름. 예) 공부
        public int Minutes { get; set; }        // 활동 시간(분)

        public GrassRecord()
        {
            Activity = "";
        }
    }
}
