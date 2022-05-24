namespace WinFormLesson_3.BesOil
{
    partial class BestOil
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
            this.gbx_GasSection = new System.Windows.Forms.GroupBox();
            this.lbl_gas = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.mtbx_withprice = new System.Windows.Forms.MaskedTextBox();
            this.mtbx_withlitr = new System.Windows.Forms.MaskedTextBox();
            this.rbtn_mebleg = new System.Windows.Forms.RadioButton();
            this.rbtn_litr = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_pricegas = new System.Windows.Forms.Label();
            this.cbx_gases = new System.Windows.Forms.ComboBox();
            this.gbx_MarketSection = new System.Windows.Forms.GroupBox();
            this.lbl_market = new System.Windows.Forms.Label();
            this.lbx_order = new System.Windows.Forms.ListBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.mtbx_count = new System.Windows.Forms.MaskedTextBox();
            this.lbl_pricefood = new System.Windows.Forms.Label();
            this.cbx_foods = new System.Windows.Forms.ComboBox();
            this.gbc_TotalSection = new System.Windows.Forms.GroupBox();
            this.btn_buy = new System.Windows.Forms.Button();
            this.lbl_total = new System.Windows.Forms.Label();
            this.pcbx_logo = new System.Windows.Forms.PictureBox();
            this.gbx_GasSection.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.gbx_MarketSection.SuspendLayout();
            this.gbc_TotalSection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbx_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // gbx_GasSection
            // 
            this.gbx_GasSection.Controls.Add(this.lbl_gas);
            this.gbx_GasSection.Controls.Add(this.groupBox4);
            this.gbx_GasSection.Controls.Add(this.label6);
            this.gbx_GasSection.Controls.Add(this.lbl_pricegas);
            this.gbx_GasSection.Controls.Add(this.cbx_gases);
            this.gbx_GasSection.Location = new System.Drawing.Point(12, 12);
            this.gbx_GasSection.Name = "gbx_GasSection";
            this.gbx_GasSection.Size = new System.Drawing.Size(416, 409);
            this.gbx_GasSection.TabIndex = 0;
            this.gbx_GasSection.TabStop = false;
            this.gbx_GasSection.Text = "Pump";
            // 
            // lbl_gas
            // 
            this.lbl_gas.AutoSize = true;
            this.lbl_gas.Font = new System.Drawing.Font("Agency FB", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_gas.Location = new System.Drawing.Point(303, 349);
            this.lbl_gas.Name = "lbl_gas";
            this.lbl_gas.Size = new System.Drawing.Size(97, 57);
            this.lbl_gas.TabIndex = 11;
            this.lbl_gas.Text = "0.00";
            this.lbl_gas.TextChanged += new System.EventHandler(this.lbl_gas_TextChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.mtbx_withprice);
            this.groupBox4.Controls.Add(this.mtbx_withlitr);
            this.groupBox4.Controls.Add(this.rbtn_mebleg);
            this.groupBox4.Controls.Add(this.rbtn_litr);
            this.groupBox4.Location = new System.Drawing.Point(44, 208);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(317, 123);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Buying";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Agency FB", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(235, 81);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 35);
            this.label9.TabIndex = 11;
            this.label9.Text = "AZN";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Agency FB", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(235, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 35);
            this.label8.TabIndex = 10;
            this.label8.Text = "L";
            // 
            // mtbx_withprice
            // 
            this.mtbx_withprice.Enabled = false;
            this.mtbx_withprice.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbx_withprice.Location = new System.Drawing.Point(178, 86);
            this.mtbx_withprice.Mask = "000";
            this.mtbx_withprice.Name = "mtbx_withprice";
            this.mtbx_withprice.Size = new System.Drawing.Size(51, 31);
            this.mtbx_withprice.TabIndex = 5;
            this.mtbx_withprice.ValidatingType = typeof(System.DateTime);
            this.mtbx_withprice.TextChanged += new System.EventHandler(this.mtbx_withprice_TextChanged);
            // 
            // mtbx_withlitr
            // 
            this.mtbx_withlitr.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbx_withlitr.Location = new System.Drawing.Point(178, 33);
            this.mtbx_withlitr.Mask = "000";
            this.mtbx_withlitr.Name = "mtbx_withlitr";
            this.mtbx_withlitr.Size = new System.Drawing.Size(51, 31);
            this.mtbx_withlitr.TabIndex = 4;
            this.mtbx_withlitr.ValidatingType = typeof(System.DateTime);
            this.mtbx_withlitr.TextChanged += new System.EventHandler(this.mtbx_withlitr_TextChanged);
            // 
            // rbtn_mebleg
            // 
            this.rbtn_mebleg.AutoSize = true;
            this.rbtn_mebleg.Font = new System.Drawing.Font("Agency FB", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_mebleg.Location = new System.Drawing.Point(6, 77);
            this.rbtn_mebleg.Name = "rbtn_mebleg";
            this.rbtn_mebleg.Size = new System.Drawing.Size(100, 40);
            this.rbtn_mebleg.TabIndex = 1;
            this.rbtn_mebleg.TabStop = true;
            this.rbtn_mebleg.Text = "Mebleg";
            this.rbtn_mebleg.UseVisualStyleBackColor = true;
            this.rbtn_mebleg.CheckedChanged += new System.EventHandler(this.rbtn_litr_CheckedChanged);
            // 
            // rbtn_litr
            // 
            this.rbtn_litr.AutoSize = true;
            this.rbtn_litr.Font = new System.Drawing.Font("Agency FB", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_litr.Location = new System.Drawing.Point(6, 24);
            this.rbtn_litr.Name = "rbtn_litr";
            this.rbtn_litr.Size = new System.Drawing.Size(66, 40);
            this.rbtn_litr.TabIndex = 0;
            this.rbtn_litr.TabStop = true;
            this.rbtn_litr.Text = "Litr";
            this.rbtn_litr.UseVisualStyleBackColor = true;
            this.rbtn_litr.CheckedChanged += new System.EventHandler(this.rbtn_litr_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Agency FB", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(104, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 35);
            this.label6.TabIndex = 9;
            this.label6.Text = "Qiymet:";
            // 
            // lbl_pricegas
            // 
            this.lbl_pricegas.AutoSize = true;
            this.lbl_pricegas.Font = new System.Drawing.Font("Agency FB", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pricegas.Location = new System.Drawing.Point(198, 118);
            this.lbl_pricegas.Name = "lbl_pricegas";
            this.lbl_pricegas.Size = new System.Drawing.Size(56, 35);
            this.lbl_pricegas.TabIndex = 8;
            this.lbl_pricegas.Text = "0.00";
            // 
            // cbx_gases
            // 
            this.cbx_gases.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbx_gases.FormattingEnabled = true;
            this.cbx_gases.Location = new System.Drawing.Point(69, 58);
            this.cbx_gases.Name = "cbx_gases";
            this.cbx_gases.Size = new System.Drawing.Size(231, 24);
            this.cbx_gases.TabIndex = 8;
            this.cbx_gases.SelectedIndexChanged += new System.EventHandler(this.cbx_gases_SelectedIndexChanged);
            // 
            // gbx_MarketSection
            // 
            this.gbx_MarketSection.Controls.Add(this.lbl_market);
            this.gbx_MarketSection.Controls.Add(this.lbx_order);
            this.gbx_MarketSection.Controls.Add(this.btn_add);
            this.gbx_MarketSection.Controls.Add(this.lbl1);
            this.gbx_MarketSection.Controls.Add(this.lbl);
            this.gbx_MarketSection.Controls.Add(this.mtbx_count);
            this.gbx_MarketSection.Controls.Add(this.lbl_pricefood);
            this.gbx_MarketSection.Controls.Add(this.cbx_foods);
            this.gbx_MarketSection.Location = new System.Drawing.Point(434, 12);
            this.gbx_MarketSection.Name = "gbx_MarketSection";
            this.gbx_MarketSection.Size = new System.Drawing.Size(435, 414);
            this.gbx_MarketSection.TabIndex = 1;
            this.gbx_MarketSection.TabStop = false;
            this.gbx_MarketSection.Text = "MiniMarket";
            // 
            // lbl_market
            // 
            this.lbl_market.AutoSize = true;
            this.lbl_market.Font = new System.Drawing.Font("Agency FB", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_market.Location = new System.Drawing.Point(304, 352);
            this.lbl_market.Name = "lbl_market";
            this.lbl_market.Size = new System.Drawing.Size(97, 57);
            this.lbl_market.TabIndex = 2;
            this.lbl_market.Text = "0.00";
            this.lbl_market.TextChanged += new System.EventHandler(this.lbl_gas_TextChanged);
            // 
            // lbx_order
            // 
            this.lbx_order.FormattingEnabled = true;
            this.lbx_order.ItemHeight = 16;
            this.lbx_order.Location = new System.Drawing.Point(6, 215);
            this.lbx_order.Name = "lbx_order";
            this.lbx_order.Size = new System.Drawing.Size(417, 116);
            this.lbx_order.TabIndex = 7;
            // 
            // btn_add
            // 
            this.btn_add.AutoSize = true;
            this.btn_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_add.Enabled = false;
            this.btn_add.Font = new System.Drawing.Font("Agency FB", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Location = new System.Drawing.Point(151, 171);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 38);
            this.btn_add.TabIndex = 6;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Agency FB", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(206, 120);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(62, 35);
            this.lbl1.TabIndex = 5;
            this.lbl1.Text = "Eded:";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Agency FB", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(6, 120);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(82, 35);
            this.lbl.TabIndex = 4;
            this.lbl.Text = "Qiymet:";
            // 
            // mtbx_count
            // 
            this.mtbx_count.Font = new System.Drawing.Font("Agency FB", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbx_count.Location = new System.Drawing.Point(314, 120);
            this.mtbx_count.Mask = "000";
            this.mtbx_count.Name = "mtbx_count";
            this.mtbx_count.Size = new System.Drawing.Size(51, 35);
            this.mtbx_count.TabIndex = 3;
            this.mtbx_count.ValidatingType = typeof(System.DateTime);
            // 
            // lbl_pricefood
            // 
            this.lbl_pricefood.AutoSize = true;
            this.lbl_pricefood.Font = new System.Drawing.Font("Agency FB", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pricefood.Location = new System.Drawing.Point(100, 120);
            this.lbl_pricefood.Name = "lbl_pricefood";
            this.lbl_pricefood.Size = new System.Drawing.Size(56, 35);
            this.lbl_pricefood.TabIndex = 1;
            this.lbl_pricefood.Text = "0.00";
            // 
            // cbx_foods
            // 
            this.cbx_foods.Location = new System.Drawing.Point(93, 58);
            this.cbx_foods.Name = "cbx_foods";
            this.cbx_foods.Size = new System.Drawing.Size(231, 24);
            this.cbx_foods.TabIndex = 0;
            this.cbx_foods.SelectedIndexChanged += new System.EventHandler(this.cbx_foods_SelectedIndexChanged);
            // 
            // gbc_TotalSection
            // 
            this.gbc_TotalSection.Controls.Add(this.btn_buy);
            this.gbc_TotalSection.Controls.Add(this.lbl_total);
            this.gbc_TotalSection.Controls.Add(this.pcbx_logo);
            this.gbc_TotalSection.Location = new System.Drawing.Point(11, 427);
            this.gbc_TotalSection.Name = "gbc_TotalSection";
            this.gbc_TotalSection.Size = new System.Drawing.Size(857, 131);
            this.gbc_TotalSection.TabIndex = 2;
            this.gbc_TotalSection.TabStop = false;
            this.gbc_TotalSection.Text = "Umumi mebleg";
            // 
            // btn_buy
            // 
            this.btn_buy.AutoSize = true;
            this.btn_buy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_buy.Font = new System.Drawing.Font("Agency FB", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buy.Location = new System.Drawing.Point(242, 37);
            this.btn_buy.Name = "btn_buy";
            this.btn_buy.Size = new System.Drawing.Size(130, 76);
            this.btn_buy.TabIndex = 7;
            this.btn_buy.Text = "BUY";
            this.btn_buy.UseVisualStyleBackColor = true;
            this.btn_buy.Click += new System.EventHandler(this.btn_buy_Click);
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Font = new System.Drawing.Font("Agency FB", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total.Location = new System.Drawing.Point(678, 37);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(173, 97);
            this.lbl_total.TabIndex = 1;
            this.lbl_total.Text = "0.00";
            // 
            // pcbx_logo
            // 
            this.pcbx_logo.BackgroundImage = global::WinFormLesson_3.Properties.Resources.gastation_logoq;
            this.pcbx_logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcbx_logo.Location = new System.Drawing.Point(6, 21);
            this.pcbx_logo.Name = "pcbx_logo";
            this.pcbx_logo.Size = new System.Drawing.Size(204, 104);
            this.pcbx_logo.TabIndex = 0;
            this.pcbx_logo.TabStop = false;
            // 
            // BestOil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 570);
            this.Controls.Add(this.gbc_TotalSection);
            this.Controls.Add(this.gbx_MarketSection);
            this.Controls.Add(this.gbx_GasSection);
            this.MaximizeBox = false;
            this.Name = "BestOil";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "BestOil";
            this.Load += new System.EventHandler(this.BestOil_Load);
            this.gbx_GasSection.ResumeLayout(false);
            this.gbx_GasSection.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.gbx_MarketSection.ResumeLayout(false);
            this.gbx_MarketSection.PerformLayout();
            this.gbc_TotalSection.ResumeLayout(false);
            this.gbc_TotalSection.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbx_logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbx_GasSection;
        private System.Windows.Forms.GroupBox gbx_MarketSection;
        private System.Windows.Forms.GroupBox gbc_TotalSection;
        private System.Windows.Forms.PictureBox pcbx_logo;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.MaskedTextBox mtbx_count;
        private System.Windows.Forms.Label lbl_pricefood;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.ListBox lbx_order;
        private System.Windows.Forms.Label lbl_market;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rbtn_mebleg;
        private System.Windows.Forms.RadioButton rbtn_litr;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_pricegas;
        private System.Windows.Forms.ComboBox cbx_gases;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox mtbx_withprice;
        private System.Windows.Forms.MaskedTextBox mtbx_withlitr;
        private System.Windows.Forms.Label lbl_gas;
        private System.Windows.Forms.Button btn_buy;
        private System.Windows.Forms.ComboBox cbx_foods;
    }
}