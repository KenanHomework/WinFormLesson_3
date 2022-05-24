using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormLesson_3.Anket_2;
using WinFormLesson_3.BesOil;

namespace WinFormLesson_3
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            while (true)
            {
                Starter starter = new Starter();
                starter.ShowDialog();
                if (starter.ToScreen == Starter.ChangeScreen.Anket)
                {
                    Anket anket = new Anket();
                    anket.ShowDialog();

                }
                else if (starter.ToScreen == Starter.ChangeScreen.BestOil)
                {
                    BestOil bestOil = new BestOil();
                    bestOil.ShowDialog();
                }
                else
                    break;

            }
        }
    }
}
