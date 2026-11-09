using System;
using System.Drawing;

namespace WinFormsCalendar
{
    // [카테고리 하나의 데이터]
    // 담을 값       : 카테고리 이름, 그 카테고리의 색
    // 사용하는 곳   : ScheduleForm(분류 고르기·색 지정), MainForm(달력 칸의 색 점, 목록 글자색), DataStore(저장)
    // 참고 수업     : 6주차 ColorDialog (색 고르기), 4주차 Color.FromArgb
    // 구분          : 확장 (카테고리별 색상)
    // 담당          : ChildrenAon
    public class Category
    {
        public String Name { get; set; }    // 카테고리 이름. 예) 학업
        public Color Color { get; set; }    // 그 카테고리의 색

        public Category(String strName, Color col)
        {
            Name = strName;
            Color = col;
        }
    }
}
