using System;
using System.Windows.Forms;

namespace WinFormsCalendar
{
    static class Program
    {
        /// <summary>
        /// 프로그램의 시작점. 메인 화면(MainForm)을 띄운다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
