using System;
using System.Windows.Forms;

namespace _2001_події_для_форми
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Створення і показ форми
            Application.Run(new Form1());
        }
    }
}