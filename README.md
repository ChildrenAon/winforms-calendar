# winforms-calendar

윈도우 프로그래밍 수업 팀 프로젝트: C# Windows Forms로 만드는 **달력·일정 관리 앱**입니다.

## 개발 환경

- Visual Studio 2022에서 빌드를 확인했습니다. (2019 이상 권장)
- .NET Framework 4.7.2, Windows Forms
- 수업 실습 프로젝트와 같은 형식의 프로젝트 파일을 사용합니다.

## 실행 방법

1. 저장소를 클론합니다.
   ```bash
   git clone https://github.com/ChildrenAon/winforms-calendar.git
   ```
2. `WinFormsCalendar.sln`을 Visual Studio로 엽니다.
3. `F5`로 실행합니다.

## 폴더 구조

```
winforms-calendar/
├─ README.md
├─ WinFormsCalendar.sln
├─ docs/
│   ├─ 작업가이드.md     어떤 기능을 어떤 파일에서 작업하는지 (먼저 읽기)
│   ├─ 기능명세.md       기능 목록, 담당, 진행 상태
│   ├─ 설계.md           화면·데이터·저장 방식 (초안)
│   └─ 발표분량.md       파일별 설명 담당
└─ WinFormsCalendar/
    ├─ Program.cs               프로그램 시작점
    ├─ MainForm.cs              메인 화면 (달력)
    ├─ Forms/                   창(폼) 하나 = 파일 하나
    │   ├─ ScheduleForm.cs      일정 등록·수정
    │   ├─ SearchForm.cs        키워드 검색
    │   ├─ TimeCapsuleForm.cs   타임캡슐 메시지
    │   ├─ GrassForm.cs         잔디 기록
    │   └─ MiniWidgetForm.cs    미니 위젯 모드
    ├─ Models/
    │   └─ Schedule.cs          일정 데이터
    └─ Data/
        └─ DataStore.cs         파일 저장·불러오기
```

각 파일 맨 위 주석에 하는 일, 열리는 곳, 참고한 수업 내용, 담당이 적혀 있습니다. **처음 참여하면 [docs/작업가이드.md](docs/작업가이드.md)부터 읽어 주세요.**

`Forms/`, `Models/`, `Data/` 폴더에는 각각 README가 있어서 폴더 안 파일이 무엇인지 설명합니다. 창(폼) 하나는 파일 3개가 한 세트이고, **직접 고치는 파일은 `XxxForm.cs`뿐**입니다. `.Designer.cs`와 `.resx`는 Visual Studio가 자동으로 관리하므로 건드리지 않습니다. ([Forms/README.md](WinFormsCalendar/Forms/README.md) 참고)

## 만들 기능

[docs/기능명세.md](docs/기능명세.md)를 참고하세요.

## 작업 규칙

- **기능 하나는 파일(폼) 하나**로 나눕니다. 같은 파일을 둘이 동시에 고치지 않기 위해서입니다.
- 새 기능은 `feature/기능이름` 브랜치에서 작업하고, 끝나면 Pull Request를 올립니다. `main`은 항상 실행되는 상태로 둡니다.
- 수업 실습에서 다룬 컨트롤과 문법 위주로 작성하고, **한글 주석**을 충분히 답니다. 발표에서 코드를 설명해야 하기 때문입니다.
- 컨트롤 이름은 `btnAdd`, `lblDate`처럼 역할이 보이게 짓습니다.
- 네임스페이스는 폴더와 상관없이 항상 `WinFormsCalendar`로 통일합니다.
- 일정 등 개인 데이터는 `data/` 폴더에 저장되며 Git에 올라가지 않습니다.
