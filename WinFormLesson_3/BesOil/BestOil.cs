using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormLesson_3.Properties;

namespace WinFormLesson_3.BesOil
{
    public partial class BestOil : Form
    {
        public BestOil()
        {
            InitializeComponent();
            CenterToScreen();
            Icon = Resources.bestoil_icon;
        }

        private void BestOil_Load(object sender, EventArgs e)
        {

        }
    }
}
