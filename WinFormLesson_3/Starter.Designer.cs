namespace WinFormLesson_3
{
    partial class Starter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Starter));
            this.btn_anket = new System.Windows.Forms.Button();
            this.btn_bestoil = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_anket
            // 
            this.btn_anket.BackColor = System.Drawing.Color.Transparent;
            this.btn_anket.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_anket.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btn_anket.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SandyBrown;
            this.btn_anket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_anket.Font = new System.Drawing.Font("Agency FB", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_anket.ForeColor = System.Drawing.Color.White;
            this.btn_anket.Location = new System.Drawing.Point(34, 173);
            this.btn_anket.Name = "btn_anket";
            this.btn_anket.Size = new System.Drawing.Size(107, 94);
            this.btn_anket.TabIndex = 0;
            this.btn_anket.Text = "Anket";
            this.btn_anket.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_anket.UseVisualStyleBackColor = false;
            this.btn_anket.Click += new System.EventHandler(this.btn_anket_Click);
            // 
            // btn_bestoil
            // 
            this.btn_bestoil.BackColor = System.Drawing.Color.Transparent;
            this.btn_bestoil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_bestoil.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btn_bestoil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SandyBrown;
            this.btn_bestoil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_bestoil.Font = new System.Drawing.Font("Agency FB", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_bestoil.ForeColor = System.Drawing.Color.White;
            this.btn_bestoil.Location = new System.Drawing.Point(656, 173);
            this.btn_bestoil.Name = "btn_bestoil";
            this.btn_bestoil.Size = new System.Drawing.Size(107, 94);
            this.btn_bestoil.TabIndex = 1;
            this.btn_bestoil.Text = "BestOil";
            this.btn_bestoil.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_bestoil.UseVisualStyleBackColor = false;
            this.btn_bestoil.Click += new System.EventHandler(this.btn_bestoil_Click);
            // 
            // Starter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::WinFormLesson_3.Properties.Resources.starter_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_bestoil);
            this.Controls.Add(this.btn_anket);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Starter";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Starter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_anket;
        private System.Windows.Forms.Button btn_bestoil;
    }
}

