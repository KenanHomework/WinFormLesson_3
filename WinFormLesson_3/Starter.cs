using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormLesson_3
{
    public partial class Starter : Form
    {
        public Starter()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public enum ChangeScreen { Anket, BestOil, Exit }


        public ChangeScreen ToScreen { get; set; } = ChangeScreen.Exit;


        private void btn_anket_Click(object sender, EventArgs e)
        {
            ToScreen = ChangeScreen.Anket;
            Close();
        }

        private void btn_bestoil_Click(object sender, EventArgs e)
        {
            ToScreen = ChangeScreen.BestOil;
            Close();
        }
    }
}
