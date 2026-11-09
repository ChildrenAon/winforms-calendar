using System;

namespace WinFormsCalendar
{
    // [타임캡슐 메시지 한 개의 데이터]
    // 담을 값       : 열어볼 날짜, 메시지, 이미 열어 봤는지 여부
    // 사용하는 곳   : TimeCapsuleForm(작성·확인), DataStore(저장·불러오기)
    // 구분          : 추가 (타임캡슐 메시지)
    // 담당          : 데이터 틀은 ChildrenAon, 사용하는 TimeCapsuleForm은 WhelkMono
    public class Capsule
    {
        public DateTime Date { get; set; }      // 이 날짜가 되면 메시지를 보여준다
        public String Message { get; set; }     // 남겨 둔 메시지
        public bool IsOpened { get; set; }      // 이미 보여 줬으면 true (같은 메시지를 또 띄우지 않으려고)

        public Capsule()
        {
            Message = "";
        }
    }
}
