# winforms-calendar

윈도우 프로그래밍 수업 팀 프로젝트: C# Windows Forms로 만드는 **달력·일정 관리 앱**입니다.

## 누가 무엇을 읽으면 되나요?

| 역할 | 먼저 볼 문서 |
|---|---|
| 개발 | [작업가이드](docs/작업가이드.md) (어떤 기능을 어떤 파일에서 작업하는지), [설계](docs/설계.md) |
| 발표 (코드 설명) | [발표분량](docs/발표분량.md) (파일별 설명 분량), [구현 화면](docs/구현화면.md), 맡은 파일 맨 위 주석 |
| PPT | [기능명세](docs/기능명세.md) (만들 기능 목록), [구현 화면](docs/구현화면.md) (실제 실행 화면), [설계](docs/설계.md) (화면·저장 방식) |

모르는 용어가 나오면 [작업가이드의 용어 풀이](docs/작업가이드.md#용어-풀이)를 보세요.

## 개발 환경

- Visual Studio 2022에서 빌드를 확인했습니다. (2019 이상 권장)
- .NET Framework 4.7.2, Windows Forms
- 수업 실습 프로젝트와 같은 형식의 프로젝트 파일을 사용합니다.

## 실행 방법

1. 저장소를 내려받습니다(클론).
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
│   ├─ 작업가이드.md     어떤 기능을 어떤 파일에서 작업하는지, 용어 풀이
│   ├─ 기능명세.md       기능 목록, 진행 상태
│   ├─ 구현화면.md       실제 실행 화면과 설명 (스크린샷)
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
    ├─ Models/                  데이터 모양
    │   ├─ Schedule.cs          일정
    │   ├─ Category.cs          카테고리(이름·색)
    │   ├─ Capsule.cs           타임캡슐 메시지
    │   └─ GrassRecord.cs       잔디 기록
    └─ Data/
        └─ DataStore.cs         파일 저장·불러오기
```

- 각 파일 맨 위 주석에 **하는 일, 열리는 곳, 참고한 수업 내용, 담당**이 적혀 있습니다.
- `Forms/`, `Models/`, `Data/` 폴더에는 각각 README가 있어서 폴더 안 파일을 설명합니다.
- 창(폼) 하나는 파일 3개가 한 세트이고, **직접 고치는 파일은 `XxxForm.cs`뿐**입니다. `.Designer.cs`와 `.resx`는 Visual Studio가 자동으로 관리하므로 건드리지 않습니다. ([Forms/README.md](WinFormsCalendar/Forms/README.md) 참고)

## 만들 기능

계획 발표에서 말한 범위는 **필수 → 추가 기능까지 만들고, 확장 아이디어는 여유가 되면** 만드는 것입니다. 자세한 목록은 [docs/기능명세.md](docs/기능명세.md)를 참고하세요.

## 팀 약속

- 기능 하나는 파일(폼) 하나로 나눕니다. 같은 파일을 둘이 동시에 고치지 않기 위해서입니다.
- 새 기능은 기능별 브랜치(작업용 사본)에서 작업하고, 끝나면 Pull Request로 합칩니다. 도구는 각자 편한 것을 씁니다.
- 수업 실습에서 다룬 컨트롤과 문법 위주로 작성하고, **한글 주석**을 충분히 답니다. 발표에서 코드를 설명해야 하기 때문입니다.
- **이름은 수업 실습 방식**을 따릅니다. 버튼은 `bt_Add`처럼 `bt_`로 시작하고(수업의 `bt_FileOpen_Click`), 클래스 안의 변수는 `m_listSchedules`처럼 `m_`로 시작하고(수업의 `m_strInfo`), 다른 창을 만들어 쓰는 변수는 `_ScheduleForm`처럼 `_`로 시작합니다(수업의 `_Form2`). 버튼이 아닌 컨트롤은 같은 모양으로 넓혀 `tb_Title`(TextBox), `lb_Month`(Label), `lv_Schedule`(ListView), `ls_Dday`(ListBox), `cb_Category`(ComboBox), `nu_Hour`(NumericUpDown), `ck_Dday`(CheckBox), `pn_`(Panel)처럼 짓습니다.
- 네임스페이스는 폴더와 상관없이 항상 `WinFormsCalendar`로 통일합니다.
- 일정 등 개인 데이터는 실행 파일 옆 `data/` 폴더에 저장되며 Git에 올라가지 않습니다.
