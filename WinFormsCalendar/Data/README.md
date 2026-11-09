# Data — 저장·불러오기

파일에 데이터를 쓰고 읽는 코드를 둡니다.

| 파일 | 구분 | 하는 일 | 참고 수업 | 브랜치 |
|---|---|---|---|---|
| `DataStore.cs` | 확장 | 일정·카테고리·타임캡슐·잔디 기록을 텍스트 파일로 저장하고 프로그램 시작 시 다시 읽어 옴 | 6주차 `File.ReadAllText` / `WriteAllText`, `try/catch` | `feature/save-load` |

- 저장 형식은 한 줄에 한 항목, `|`로 구분하고 맨 앞 글자(`K` 카테고리, `S` 일정, `C` 타임캡슐, `G` 잔디)로 종류를 구분합니다. 자세한 내용은 [설계 문서](../../docs/설계.md)를 참고하세요.
- 저장 위치는 실행 폴더의 `data\calendar.txt`이며 Git에는 올라가지 않습니다.
- 사용법: `DataStore.Save(...)`와 `DataStore.Load(...)`는 메인 화면이 부릅니다. 각 창에서는 `m_Parent.SaveAll()`만 부르면 됩니다.
- 네임스페이스는 항상 `WinFormsCalendar`입니다.
