using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
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
            petrols.Add(new Petrol("Diesel", 0.80));
            petrols.Add(new Petrol("A-92", 1.00));
            petrols.Add(new Petrol("AI-95", 1.60));
            petrols.Add(new Petrol("AI-98", 1.80));
            foods.Add(new Food("Hotdog", 4.0));
            foods.Add(new Food("Qamburger", 5.4));
            foods.Add(new Food("Fri", 7.2));
            foods.Add(new Food("Coca-cola", 4.4));
            petrols.ForEach(p => cbx_gases.Items.Add(p));
            foods.ForEach(f => cbx_foods.Items.Add(f));
            rbtn_litr.Enabled = false;
            rbtn_mebleg.Enabled = false;
            btn_add.Enabled = false;
        }
        List<Petrol> petrols = new List<Petrol>();

        List<Food> foods = new List<Food>();

        List<Food> orders = new List<Food>();


        private void BestOil_Load(object sender, EventArgs e)
        {

        }
        private void cbx_gases_SelectedIndexChanged(object sender, EventArgs e)
        {
            rbtn_litr.Enabled = true;
            rbtn_mebleg.Enabled = true;
            lbl_pricegas.Text = petrols[cbx_gases.SelectedIndex].Price.ToString();
            ChangeGasPrice();
        }

        private void rbtn_litr_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn_litr.Checked)
            {
                lbl_gas.ResetText();
                mtbx_withprice.ResetText();
                mtbx_withlitr.Enabled = true;
                mtbx_withprice.Enabled = false;
            }
            else
            {
                lbl_gas.ResetText();
                mtbx_withlitr.ResetText();
                mtbx_withlitr.Enabled = false;
                mtbx_withprice.Enabled = true;
            }
        }


        public void ChangeGasPrice()
        {
            if (rbtn_mebleg.Checked)
                CountGas = Convert.ToDouble(mtbx_withprice.Text) / Convert.ToDouble(lbl_pricegas.Text);
            lbl_gas.Text = (CountGas * Convert.ToDouble(lbl_pricegas.Text)).ToString();
        }
        private void mtbx_withlitr_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(mtbx_withlitr.Text))
            {
                CountGas = Convert.ToDouble(mtbx_withlitr.Text);
                ChangeGasPrice();
            }
        }
        double CountGas = 0;

        private void mtbx_withprice_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(mtbx_withprice.Text))
            {
                CountGas = Convert.ToDouble(mtbx_withprice.Text) / Convert.ToDouble(lbl_pricegas.Text);
                ChangeGasPrice();
            }
        }

        private void lbl_gas_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(lbl_gas.Text))
            {
                if (!string.IsNullOrWhiteSpace(lbl_market.Text))
                    lbl_total.Text = (Convert.ToDouble(lbl_gas.Text) + Convert.ToDouble(lbl_market.Text)).ToString();
                else
                    lbl_total.Text = (Convert.ToDouble(lbl_gas.Text) + Convert.ToDouble(lbl_total.Text)).ToString();
            }
        }

        private void cbx_foods_SelectedIndexChanged(object sender, EventArgs e)
        {
            btn_add.Enabled = true;
            mtbx_count.Text = "1";
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            Food food = new Food(foods[cbx_foods.SelectedIndex].Name
                , foods[cbx_foods.SelectedIndex].Price * Convert.ToInt32(mtbx_count.Text)
                );
            if (orders.Find(f => f.Name == food.Name) == null)
            {
                lbx_order.Items.Add(food);
                orders.Add(food);
            }
            else
                MessageBox.Show($"{food.Name} Already Added !", "Add Food", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            // Change Mebleg
            lbl_market.Text = "0";
            orders.ForEach(f =>
            lbl_market.Text = (Convert.ToDouble(lbl_market.Text) + f.Price).ToString());

        }

        private void lbx_order_ControlAdded(object sender, ControlEventArgs e)
        {
            MessageBox.Show("asdasdasdasdasd", "Add Food", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btn_buy_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show($"Youy allow progrecc ?\nTotal Price: {lbl_total.Text}", "Buying", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                SoundPlayer soundPlayer = new SoundPlayer(Resources.Buying_Sound_Effect);
                soundPlayer.Play();
                lbl_total.Text = "0.00";
                lbl_gas.Text = "0.00";
                lbl_market.Text = "0.00";
                rbtn_litr.Enabled = false;
                rbtn_mebleg.Enabled = false;
                btn_add.Enabled = false;
                rbtn_litr.Enabled = false;
                rbtn_mebleg.Enabled = false;
                mtbx_count.Enabled = false;
                mtbx_withlitr.Enabled = false;
                mtbx_withlitr.Enabled = false;
            }
        }
    }
}
