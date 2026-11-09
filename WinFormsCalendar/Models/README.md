# Models — 데이터 모양

화면이 아니라 **데이터가 어떤 값으로 이루어져 있는지**를 정의하는 클래스를 둡니다.

| 파일 | 구분 | 하는 일 | 사용하는 곳 | 브랜치 |
|---|---|---|---|---|
| `Schedule.cs` | 필수 | 일정 한 개가 담을 값(날짜, 시·분, 제목, 메모, 카테고리, 첨부 파일 경로, D-day 표시 여부) | 메인 화면(목록·점), `ScheduleForm`(입력), `DataStore`(저장) | `feature/schedule` |
| `Category.cs` | 확장 | 카테고리 이름과 색 | `ScheduleForm`(분류·색 지정), 메인 화면(점·글자 색) | `feature/schedule` |
| `Capsule.cs` | 추가 | 타임캡슐 메시지 한 개(열어볼 날짜, 메시지, 열어 봤는지) | `TimeCapsuleForm` | `feature/time-capsule` |
| `GrassRecord.cs` | 확장 | 잔디 기록 한 개(날짜, 활동 이름, 시간(분)) | `GrassForm`, 메인 화면(칸 색) | `feature/grass` |

- 값은 수업 5·7주차 `LoginCheck`처럼 get/set 프로퍼티로 담습니다. 자세한 내용은 [설계 문서](../../docs/설계.md)를 참고하세요.
- 네임스페이스는 항상 `WinFormsCalendar`입니다.
