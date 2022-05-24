namespace WinFormLesson_3.Anket_2
{
    partial class Anket
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbx_Anket = new System.Windows.Forms.GroupBox();
            this.mtbx_phone = new System.Windows.Forms.MaskedTextBox();
            this.dp_birthdate = new System.Windows.Forms.DateTimePicker();
            this.btn_save_change = new System.Windows.Forms.Button();
            this.lbl_birthdate = new System.Windows.Forms.Label();
            this.lbl_phone = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.tbx_email = new System.Windows.Forms.TextBox();
            this.lbl_surname = new System.Windows.Forms.Label();
            this.tbx_surname = new System.Windows.Forms.TextBox();
            this.lbl_name = new System.Windows.Forms.Label();
            this.tbx_name = new System.Windows.Forms.TextBox();
            this.gbx_Load = new System.Windows.Forms.GroupBox();
            this.tbx_filename = new System.Windows.Forms.TextBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_load = new System.Windows.Forms.Button();
            this.lbx_files = new System.Windows.Forms.ListBox();
            this.lbl_filename = new System.Windows.Forms.Label();
            this.gbx_Anket.SuspendLayout();
            this.gbx_Load.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbx_Anket
            // 
            this.gbx_Anket.BackColor = System.Drawing.Color.Transparent;
            this.gbx_Anket.Controls.Add(this.mtbx_phone);
            this.gbx_Anket.Controls.Add(this.dp_birthdate);
            this.gbx_Anket.Controls.Add(this.btn_save_change);
            this.gbx_Anket.Controls.Add(this.lbl_birthdate);
            this.gbx_Anket.Controls.Add(this.lbl_phone);
            this.gbx_Anket.Controls.Add(this.lbl_email);
            this.gbx_Anket.Controls.Add(this.tbx_email);
            this.gbx_Anket.Controls.Add(this.lbl_surname);
            this.gbx_Anket.Controls.Add(this.tbx_surname);
            this.gbx_Anket.Controls.Add(this.lbl_name);
            this.gbx_Anket.Controls.Add(this.tbx_name);
            this.gbx_Anket.ForeColor = System.Drawing.Color.White;
            this.gbx_Anket.Location = new System.Drawing.Point(12, 12);
            this.gbx_Anket.Name = "gbx_Anket";
            this.gbx_Anket.Size = new System.Drawing.Size(505, 508);
            this.gbx_Anket.TabIndex = 0;
            this.gbx_Anket.TabStop = false;
            this.gbx_Anket.Text = "Anket";
            // 
            // mtbx_phone
            // 
            this.mtbx_phone.Font = new System.Drawing.Font("Agency FB", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbx_phone.Location = new System.Drawing.Point(180, 209);
            this.mtbx_phone.Mask = "(999) 000-00-00";
            this.mtbx_phone.Name = "mtbx_phone";
            this.mtbx_phone.Size = new System.Drawing.Size(288, 25);
            this.mtbx_phone.TabIndex = 3;
            this.mtbx_phone.TextChanged += new System.EventHandler(this.mtbx_phone_TextChanged);
            // 
            // dp_birthdate
            // 
            this.dp_birthdate.Location = new System.Drawing.Point(180, 260);
            this.dp_birthdate.MaxDate = new System.DateTime(2022, 12, 31, 0, 0, 0, 0);
            this.dp_birthdate.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dp_birthdate.Name = "dp_birthdate";
            this.dp_birthdate.Size = new System.Drawing.Size(288, 22);
            this.dp_birthdate.TabIndex = 4;
            this.dp_birthdate.Value = new System.DateTime(2022, 5, 24, 0, 0, 0, 0);
            // 
            // btn_save_change
            // 
            this.btn_save_change.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_save_change.Font = new System.Drawing.Font("Agency FB", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save_change.ForeColor = System.Drawing.Color.Black;
            this.btn_save_change.Location = new System.Drawing.Point(364, 333);
            this.btn_save_change.Name = "btn_save_change";
            this.btn_save_change.Size = new System.Drawing.Size(104, 46);
            this.btn_save_change.TabIndex = 5;
            this.btn_save_change.Text = "Save";
            this.btn_save_change.UseVisualStyleBackColor = true;
            this.btn_save_change.Click += new System.EventHandler(this.btn_save_change_Click);
            // 
            // lbl_birthdate
            // 
            this.lbl_birthdate.AutoSize = true;
            this.lbl_birthdate.Font = new System.Drawing.Font("Agency FB", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_birthdate.ForeColor = System.Drawing.Color.White;
            this.lbl_birthdate.Location = new System.Drawing.Point(26, 248);
            this.lbl_birthdate.Name = "lbl_birthdate";
            this.lbl_birthdate.Size = new System.Drawing.Size(135, 35);
            this.lbl_birthdate.TabIndex = 9;
            this.lbl_birthdate.Text = "Dogum Tarixi";
            // 
            // lbl_phone
            // 
            this.lbl_phone.AutoSize = true;
            this.lbl_phone.Font = new System.Drawing.Font("Agency FB", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_phone.ForeColor = System.Drawing.Color.White;
            this.lbl_phone.Location = new System.Drawing.Point(75, 201);
            this.lbl_phone.Name = "lbl_phone";
            this.lbl_phone.Size = new System.Drawing.Size(86, 35);
            this.lbl_phone.TabIndex = 7;
            this.lbl_phone.Text = "Telefon:";
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Font = new System.Drawing.Font("Agency FB", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_email.ForeColor = System.Drawing.Color.White;
            this.lbl_email.Location = new System.Drawing.Point(94, 158);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(67, 35);
            this.lbl_email.TabIndex = 5;
            this.lbl_email.Text = "Email:";
            // 
            // tbx_email
            // 
            this.tbx_email.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbx_email.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_email.Location = new System.Drawing.Point(180, 166);
            this.tbx_email.Name = "tbx_email";
            this.tbx_email.Size = new System.Drawing.Size(288, 24);
            this.tbx_email.TabIndex = 2;
            this.tbx_email.TextChanged += new System.EventHandler(this.tbx_email_TextChanged);
            // 
            // lbl_surname
            // 
            this.lbl_surname.AutoSize = true;
            this.lbl_surname.Font = new System.Drawing.Font("Agency FB", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_surname.ForeColor = System.Drawing.Color.White;
            this.lbl_surname.Location = new System.Drawing.Point(85, 114);
            this.lbl_surname.Name = "lbl_surname";
            this.lbl_surname.Size = new System.Drawing.Size(76, 35);
            this.lbl_surname.TabIndex = 3;
            this.lbl_surname.Text = "Soyad:";
            // 
            // tbx_surname
            // 
            this.tbx_surname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbx_surname.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_surname.Location = new System.Drawing.Point(180, 125);
            this.tbx_surname.Name = "tbx_surname";
            this.tbx_surname.Size = new System.Drawing.Size(288, 24);
            this.tbx_surname.TabIndex = 1;
            this.tbx_surname.TextChanged += new System.EventHandler(this.tbx_surname_TextChanged);
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Agency FB", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.ForeColor = System.Drawing.Color.White;
            this.lbl_name.Location = new System.Drawing.Point(118, 70);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(43, 35);
            this.lbl_name.TabIndex = 1;
            this.lbl_name.Text = "AD:";
            // 
            // tbx_name
            // 
            this.tbx_name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbx_name.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_name.Location = new System.Drawing.Point(180, 78);
            this.tbx_name.Name = "tbx_name";
            this.tbx_name.Size = new System.Drawing.Size(288, 24);
            this.tbx_name.TabIndex = 0;
            this.tbx_name.TextChanged += new System.EventHandler(this.tbx_name_TextChanged);
            // 
            // gbx_Load
            // 
            this.gbx_Load.BackColor = System.Drawing.Color.Transparent;
            this.gbx_Load.Controls.Add(this.lbl_filename);
            this.gbx_Load.Controls.Add(this.tbx_filename);
            this.gbx_Load.Controls.Add(this.btn_save);
            this.gbx_Load.Controls.Add(this.btn_load);
            this.gbx_Load.Controls.Add(this.lbx_files);
            this.gbx_Load.ForeColor = System.Drawing.Color.White;
            this.gbx_Load.Location = new System.Drawing.Point(523, 14);
            this.gbx_Load.Name = "gbx_Load";
            this.gbx_Load.Size = new System.Drawing.Size(362, 506);
            this.gbx_Load.TabIndex = 1;
            this.gbx_Load.TabStop = false;
            this.gbx_Load.Text = "Load";
            // 
            // tbx_filename
            // 
            this.tbx_filename.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbx_filename.Location = new System.Drawing.Point(111, 399);
            this.tbx_filename.Name = "tbx_filename";
            this.tbx_filename.Size = new System.Drawing.Size(245, 22);
            this.tbx_filename.TabIndex = 7;
            this.tbx_filename.TextChanged += new System.EventHandler(this.tbx_filename_TextChanged);
            // 
            // btn_save
            // 
            this.btn_save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_save.Font = new System.Drawing.Font("Agency FB", 13.8F, System.Drawing.FontStyle.Italic);
            this.btn_save.ForeColor = System.Drawing.Color.Black;
            this.btn_save.Location = new System.Drawing.Point(186, 427);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(170, 48);
            this.btn_save.TabIndex = 8;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_load
            // 
            this.btn_load.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_load.Font = new System.Drawing.Font("Agency FB", 13.8F, System.Drawing.FontStyle.Italic);
            this.btn_load.ForeColor = System.Drawing.Color.Black;
            this.btn_load.Location = new System.Drawing.Point(6, 427);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(170, 48);
            this.btn_load.TabIndex = 8;
            this.btn_load.Text = "Load";
            this.btn_load.UseVisualStyleBackColor = true;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // lbx_files
            // 
            this.lbx_files.FormattingEnabled = true;
            this.lbx_files.ItemHeight = 16;
            this.lbx_files.Location = new System.Drawing.Point(6, 21);
            this.lbx_files.Name = "lbx_files";
            this.lbx_files.Size = new System.Drawing.Size(350, 356);
            this.lbx_files.TabIndex = 6;
            this.lbx_files.SelectedIndexChanged += new System.EventHandler(this.lbx_files_SelectedIndexChanged);
            // 
            // lbl_filename
            // 
            this.lbl_filename.AutoSize = true;
            this.lbl_filename.Font = new System.Drawing.Font("Agency FB", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_filename.ForeColor = System.Drawing.Color.White;
            this.lbl_filename.Location = new System.Drawing.Point(6, 389);
            this.lbl_filename.Name = "lbl_filename";
            this.lbl_filename.Size = new System.Drawing.Size(99, 35);
            this.lbl_filename.TabIndex = 10;
            this.lbl_filename.Text = "Filename:";
            // 
            // Anket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WinFormLesson_3.Properties.Resources.anket;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(898, 530);
            this.Controls.Add(this.gbx_Load);
            this.Controls.Add(this.gbx_Anket);
            this.MaximizeBox = false;
            this.Name = "Anket";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Anket";
            this.gbx_Anket.ResumeLayout(false);
            this.gbx_Anket.PerformLayout();
            this.gbx_Load.ResumeLayout(false);
            this.gbx_Load.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbx_Anket;
        private System.Windows.Forms.GroupBox gbx_Load;
        private System.Windows.Forms.TextBox tbx_filename;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_load;
        private System.Windows.Forms.ListBox lbx_files;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.TextBox tbx_name;
        private System.Windows.Forms.Button btn_save_change;
        private System.Windows.Forms.Label lbl_birthdate;
        private System.Windows.Forms.Label lbl_phone;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.TextBox tbx_email;
        private System.Windows.Forms.Label lbl_surname;
        private System.Windows.Forms.TextBox tbx_surname;
        private System.Windows.Forms.DateTimePicker dp_birthdate;
        private System.Windows.Forms.MaskedTextBox mtbx_phone;
        private System.Windows.Forms.Label lbl_filename;
    }
}