using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormLesson_3.Properties;
using Newtonsoft.Json;

namespace WinFormLesson_3.Anket_2
{
    public partial class Anket : Form
    {
        public Anket()
        {
            InitializeComponent();
            CenterToScreen();
            Icon = Resources.anket_icon;
            dp_birthdate.MaxDate = DateTime.Now.AddHours(3);
            dp_birthdate.Value = DateTime.Now;
        }

        List<User> users = new List<User>();

        public enum ChaneScreen { Starter }

        public ChaneScreen ToScreen { get; set; }

        public void CheckTexBox(ref TextBox tbx, ref Label lbl, ref bool control, string regex)
        {
            if (Reseting)
                return;
            if (tbx.Text.Length > 2)

                if (new Regex(regex).IsMatch(tbx.Text))
                {
                    control = true;
                    lbl.ForeColor = Color.White;
                    tbx.BackColor = Color.White;
                }
                else
                {
                    control = false;
                    lbl.ForeColor = Color.Red;
                    tbx.BackColor = Color.Red;
                }
            else
            {

                control = false;
                lbl.ForeColor = Color.Red;
                tbx.BackColor = Color.Red;
            }
        }
        string MTrim(string txt, string trimChars)
        {
            StringBuilder sb = new StringBuilder();
            txt.ToList().ForEach(delegate (Char ch)
            {
                if (!trimChars.Contains(ch))
                    sb.Append(ch);
            });
            return sb.ToString();
        }
        public void CheckTexBox(ref MaskedTextBox tbx, ref Label lbl, ref bool control, string regex)
        {
            if (Reseting)
                return;
            if (MTrim(tbx.Text, " ()-").Length > 9)

                if (new Regex(regex).IsMatch(MTrim(tbx.Text, " ()-")))
                {
                    control = true;
                    lbl.ForeColor = Color.White;
                    tbx.BackColor = Color.White;
                }
                else
                {
                    control = false;
                    lbl.ForeColor = Color.Red;
                    tbx.BackColor = Color.Red;
                }
            else
            {

                control = false;
                lbl.ForeColor = Color.Red;
                tbx.BackColor = Color.Red;
            }
        }


        bool CName = false;
        bool CSurname = false;
        bool CEmail = false;
        bool CFilename = false;
        bool CPhone = false;


        private void tbx_name_TextChanged(object sender, EventArgs e)
            => CheckTexBox(ref tbx_name, ref lbl_name, ref CName, "^([A-Za-z]+([ ]?[a-z]?['-]?[A-Za-z]+)*)$");

        private void tbx_surname_TextChanged(object sender, EventArgs e)
            => CheckTexBox(ref tbx_surname, ref lbl_surname, ref CSurname, "^([A-Za-z]+([ ]?[a-z]?['-]?[A-Za-z]+)*)$");

        private void tbx_email_TextChanged(object sender, EventArgs e)
            => CheckTexBox(ref tbx_email, ref lbl_email, ref CEmail, "[a-z0-9!#$%&'*+//=?^_`{|}~-]+(?:\\.[a-z0-9!#$%&'*+//=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?");


        private void mtbx_phone_TextChanged(object sender, EventArgs e)
                    => CheckTexBox(ref mtbx_phone, ref lbl_phone, ref CPhone, "^099|055|050|077|070|010");
        private void tbx_filename_TextChanged(object sender, EventArgs e)
            => CheckTexBox(ref tbx_filename, ref lbl_filename, ref CFilename, "[A-Za-z0-9_-]*");


        public bool CheckFields()
        {
            if (CName)
                if (CSurname)
                    if (CPhone)
                        return true;

            return false;
        }

        public bool CheckTextEmpty(object item)
        {
            if (item is TextBox tbx)
                return string.IsNullOrWhiteSpace(tbx.Text);
            else if (item is MaskedTextBox mtbx)
            {
                return string.IsNullOrWhiteSpace(MTrim(mtbx.Text, " _-()"));
            }
            else if (item is DateTimePicker dp)
                return dp.Value.ToLongDateString().Equals(DateTime.Now.ToLongDateString());
            return true;

        }

        public bool AnyFieldFilled()
        {
            var formCntrl = this.Controls;
            foreach (var item in formCntrl)
            {
                if (item is GroupBox gb)
                    foreach (var element in gb.Controls)
                    {
                        if (element is Button) { continue; }
                        if (!CheckTextEmpty(element))
                            return true;
                    }
                else
                {
                    if (!CheckTextEmpty(item))
                        return true;
                }
            }
            return false;
        }
        void ResetValue(ref Control item)
        {
            if (item is TextBox tbx)
            {
                tbx.ResetText();
                tbx.BackColor = Color.White;
            }
            else if (item is Label lbl)
                lbl.ForeColor = Color.White;
            else
            if (item is MaskedTextBox mtbx)
            {
                mtbx.ResetText();
                mtbx.BackColor = Color.White;
            }
            else if (item is DateTimePicker dp)
                dp.Value = DateTime.Now.ToLocalTime();
            else if (item is ListBox lbx && ResetAll)
                lbx.Items.Clear();

        }

        bool ResetAll = false;
        public bool Reseting { get; set; } = false;
        public void Reset()
        {
            Reseting = true;
            var formCntrl = this.Controls;
            for (int e = 0; e < formCntrl.Count; e++)
            {
                if (formCntrl[e] is GroupBox gb)
                    for (int i = 0; i < gb.Controls.Count; i++)
                        ResetValue(ref gb.Controls.Find(gb.Controls[i].Name, false)[0]);
                else
                    ResetValue(ref formCntrl.Find(formCntrl[e].Name, false)[0]);
            }

            CName = false;
            CSurname = false;
            CEmail = false;
            CPhone = false;
            Reseting = false;
            ResetAll = false;
        }

        public void FillFields(User user)
        {
            tbx_name.Text = user.Name;
            tbx_surname.Text = user.Surname;
            tbx_email.Text = user.Email;
            mtbx_phone.Text = user.Phone;
            dp_birthdate.Value = user.BirthDate;
        }

        private void btn_save_change_Click(object sender, EventArgs e)
        {
            if (btn_save_change.Text == "Save")
            {
                if (CheckFields())
                {
                    if (users.Find(u => u.Name == tbx_name.Text && u.Surname == tbx_surname.Text) != null)
                    {
                        MessageBox.Show("This user already exist !", "Save Informations", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        User user = new User(tbx_name.Text, tbx_surname.Text, tbx_email.Text, mtbx_phone.Text, dp_birthdate.Value);
                        lbx_files.Items.Add(user);
                        users.Add(user);
                        Reset();
                    }
                }
                else
                    MessageBox.Show("Please Correctly Fill All Informations!", "Save Informations", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (CheckFields())
                {
                    User user = new User(tbx_name.Text, tbx_surname.Text, tbx_email.Text, mtbx_phone.Text, dp_birthdate.Value);
                    users.Find(u => u.Name == tbx_name.Text && u.Surname == tbx_surname.Text).Change(user);
                    Reset();
                }
                else
                    MessageBox.Show("Please Correctly Fill All Informations!", "Save Informations", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btn_load_Click(object sender, EventArgs e)
        {
            void Fill()
            {
                ResetAll = true;
                users = JsonConvert.DeserializeObject<List<User>>(File.ReadAllText($"{tbx_filename.Text}.json"));
                Reset();
                users.ForEach(u => lbx_files.Items.Add(u));
                MessageBox.Show("Succes !", "Load", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (CFilename)
            {
                if (!AnyFieldFilled() || lbx_files.Items.Count <= 0)
                {
                    if (File.Exists($"{tbx_filename.Text}.json"))
                    {
                        Fill();
                    }
                    else
                        MessageBox.Show("File Not Found!", "Save", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {

                    DialogResult result = MessageBox.Show("filled element found!\nDo you want to continue ?\n* Continue status changes will be lost!", "Load File Data", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        Fill();
                    }
                }
            }
            else
                MessageBox.Show("Please Correctly write Filename!", "Save", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }


        public void ChangeUpdateMode()
        {
            lbl_name.ForeColor = Color.DarkGray;
            lbl_surname.ForeColor = Color.DarkGray;
            lbl_birthdate.ForeColor = Color.DarkGray;
            tbx_name.Enabled = false;
            tbx_surname.Enabled = false;
            dp_birthdate.Enabled = false;
            btn_save_change.Text = "Change";
        }
        private void lbx_files_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (AnyFieldFilled())
            {
                DialogResult result = MessageBox.Show("filled element found!\nDo you want to continue ?\n* Continue status changes will be lost!",
                     "Load Use Data",
                     MessageBoxButtons.YesNo,
                     MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    FillFields(users[lbx_files.SelectedIndex]);
                    ChangeUpdateMode();
                }
            }
            else
            {
                FillFields(users[lbx_files.SelectedIndex]);
                ChangeUpdateMode();
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (CFilename)
            {
                File.WriteAllText($"{tbx_filename.Text}.json", JsonConvert.SerializeObject(users, Formatting.Indented));
                ResetAll = true;
                Reset();
                MessageBox.Show("Succes !", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Please Correctly write Filename!", "Save", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
    }
}
