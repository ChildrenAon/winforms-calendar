using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace WinFormsCalendar
{
    // [파일 저장·불러오기]
    // 하는 일   : 일정, 카테고리, 타임캡슐, 잔디 기록을 텍스트 파일 하나에 저장하고 프로그램 시작 시 다시 읽어 온다.
    // 저장 형식 : 한 줄에 한 항목, '|'로 구분, 맨 앞 글자로 종류를 구분한다. (docs/설계.md 참고)
    //               K|카테고리 이름|색
    //               S|날짜|시|분|제목|메모|카테고리|첨부 파일 경로|D-day(1/0)
    //               C|날짜|메시지|열어 봄(1/0)
    //               G|날짜|활동 이름|분
    // 저장 위치 : 실행 폴더의 data\calendar.txt (Git에는 올라가지 않는다)
    // 참고 수업 : 6주차 File.ReadAllText / WriteAllText, try-catch
    //             수업에 없는 것: File.ReadAllLines / WriteAllLines(줄 단위 읽기·쓰기), Split(글자로 나누기)
    // 구분      : 확장 (설계 문서의 구현 순서 참고)
    // 담당      : ChildrenAon
    public static class DataStore
    {
        // 저장 폴더. null이면 실행 폴더 아래 data 폴더를 쓴다. (시험할 때만 다른 폴더로 바꾼다)
        public static String DataFolder = null;

        private static String GetFilePath()
        {
            String strFolder = DataFolder;
            if (strFolder == null)
                strFolder = Path.Combine(Application.StartupPath, "data");
            return Path.Combine(strFolder, "calendar.txt");
        }

        // 날짜를 "2026-11-02" 모양의 글자로 바꾼다
        private static String DateText(DateTime dt)
        {
            return dt.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);
        }

        private static DateTime ParseDate(String str)
        {
            return DateTime.ParseExact(str, "yyyy-MM-dd", CultureInfo.InvariantCulture);
        }

        // 파일 한 줄에 '|'와 줄바꿈이 섞이면 줄이 깨지므로 다른 글자로 바꿔 저장한다.
        //   \ → \\    | → \p    줄바꿈 → \n
        private static String Encode(String str)
        {
            if (str == null) return "";
            StringBuilder sb = new StringBuilder();
            foreach (char ch in str)
            {
                if (ch == '\\') sb.Append("\\\\");
                else if (ch == '|') sb.Append("\\p");
                else if (ch == '\n') sb.Append("\\n");
                else if (ch == '\r') { }        // 줄바꿈의 \r은 저장하지 않는다
                else sb.Append(ch);
            }
            return sb.ToString();
        }

        // Encode 의 반대: 저장할 때 바꾼 글자를 원래대로 되돌린다
        private static String Decode(String str)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < str.Length; i++)
            {
                char ch = str[i];
                if (ch == '\\' && i + 1 < str.Length)
                {
                    i++;
                    char next = str[i];
                    if (next == 'p') sb.Append('|');
                    else if (next == 'n') sb.Append("\r\n");
                    else sb.Append(next);
                }
                else sb.Append(ch);
            }
            return sb.ToString();
        }

        // 모든 데이터를 파일에 저장한다
        public static void Save(List<Schedule> listSchedule, List<Category> listCategory,
                                List<Capsule> listCapsule, List<GrassRecord> listGrass)
        {
            try
            {
                List<String> listLine = new List<String>();

                foreach (Category c in listCategory)
                    listLine.Add("K|" + Encode(c.Name) + "|" + c.Color.ToArgb());

                foreach (Schedule s in listSchedule)
                    listLine.Add("S|" + DateText(s.Date) + "|" + s.Hour + "|" + s.Minute + "|" +
                                 Encode(s.Title) + "|" + Encode(s.Memo) + "|" + Encode(s.Category) + "|" +
                                 Encode(s.AttachPath) + "|" + (s.IsDday ? "1" : "0"));

                foreach (Capsule c in listCapsule)
                    listLine.Add("C|" + DateText(c.Date) + "|" + Encode(c.Message) + "|" + (c.IsOpened ? "1" : "0"));

                foreach (GrassRecord g in listGrass)
                    listLine.Add("G|" + DateText(g.Date) + "|" + Encode(g.Activity) + "|" + g.Minutes);

                String strFile = GetFilePath();
                Directory.CreateDirectory(Path.GetDirectoryName(strFile));   // data 폴더가 없으면 만든다
                File.WriteAllLines(strFile, listLine.ToArray(), Encoding.UTF8);
            }
            catch (Exception ex)
            {
                MessageBox.Show("저장하지 못했습니다.\n" + ex.Message);
            }
            finally { }
        }

        // 파일에서 데이터를 읽어 목록에 채운다. (목록은 먼저 비운다. 파일이 없으면 빈 채로 둔다)
        public static void Load(List<Schedule> listSchedule, List<Category> listCategory,
                                List<Capsule> listCapsule, List<GrassRecord> listGrass)
        {
            listSchedule.Clear();
            listCategory.Clear();
            listCapsule.Clear();
            listGrass.Clear();

            String strFile = GetFilePath();
            if (!File.Exists(strFile)) return;

            String[] arrLine;
            try
            {
                arrLine = File.ReadAllLines(strFile, Encoding.UTF8);
            }
            catch (Exception ex)
            {
                MessageBox.Show("저장된 파일을 읽지 못했습니다.\n" + ex.Message);
                return;
            }
            finally { }

            foreach (String strLine in arrLine)
            {
                if (strLine.Trim() == "") continue;

                try
                {
                    String[] arr = strLine.Split('|');

                    if (arr[0] == "K" && arr.Length >= 3)
                    {
                        listCategory.Add(new Category(Decode(arr[1]), Color.FromArgb(int.Parse(arr[2]))));
                    }
                    else if (arr[0] == "S" && arr.Length >= 9)
                    {
                        Schedule s = new Schedule();
                        s.Date = ParseDate(arr[1]);
                        s.Hour = int.Parse(arr[2]);
                        s.Minute = int.Parse(arr[3]);
                        s.Title = Decode(arr[4]);
                        s.Memo = Decode(arr[5]);
                        s.Category = Decode(arr[6]);
                        s.AttachPath = Decode(arr[7]);
                        s.IsDday = (arr[8] == "1");
                        listSchedule.Add(s);
                    }
                    else if (arr[0] == "C" && arr.Length >= 4)
                    {
                        Capsule c = new Capsule();
                        c.Date = ParseDate(arr[1]);
                        c.Message = Decode(arr[2]);
                        c.IsOpened = (arr[3] == "1");
                        listCapsule.Add(c);
                    }
                    else if (arr[0] == "G" && arr.Length >= 4)
                    {
                        GrassRecord g = new GrassRecord();
                        g.Date = ParseDate(arr[1]);
                        g.Activity = Decode(arr[2]);
                        g.Minutes = int.Parse(arr[3]);
                        listGrass.Add(g);
                    }
                }
                catch (Exception)
                {
                    // 한 줄이 깨져 있어도 나머지 줄은 계속 읽는다
                }
                finally { }
            }
        }
    }
}
