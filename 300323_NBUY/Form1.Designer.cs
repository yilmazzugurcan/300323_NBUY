namespace _300323_NBUY
{
    partial class Form1
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
            this.cmbYiyecek = new System.Windows.Forms.ComboBox();
            this.cmbCesit = new System.Windows.Forms.ComboBox();
            this.lstYiyeceks = new System.Windows.Forms.ListView();
            this.btnEkle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbYiyecek
            // 
            this.cmbYiyecek.FormattingEnabled = true;
            this.cmbYiyecek.Items.AddRange(new object[] {
            "Yiyecek",
            "İçecek"});
            this.cmbYiyecek.Location = new System.Drawing.Point(32, 30);
            this.cmbYiyecek.Name = "cmbYiyecek";
            this.cmbYiyecek.Size = new System.Drawing.Size(225, 21);
            this.cmbYiyecek.TabIndex = 0;
            this.cmbYiyecek.SelectedIndexChanged += new System.EventHandler(this.cmbYiyecek_SelectedIndexChanged);
            // 
            // cmbCesit
            // 
            this.cmbCesit.FormattingEnabled = true;
            this.cmbCesit.Location = new System.Drawing.Point(32, 72);
            this.cmbCesit.Name = "cmbCesit";
            this.cmbCesit.Size = new System.Drawing.Size(225, 21);
            this.cmbCesit.TabIndex = 2;
            this.cmbCesit.SelectedIndexChanged += new System.EventHandler(this.cmbCesit_SelectedIndexChanged);
            // 
            // lstYiyeceks
            // 
            this.lstYiyeceks.HideSelection = false;
            this.lstYiyeceks.Location = new System.Drawing.Point(32, 121);
            this.lstYiyeceks.Name = "lstYiyeceks";
            this.lstYiyeceks.Size = new System.Drawing.Size(225, 283);
            this.lstYiyeceks.TabIndex = 3;
            this.lstYiyeceks.UseCompatibleStateImageBehavior = false;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(297, 30);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(141, 23);
            this.btnEkle.TabIndex = 4;
            this.btnEkle.Text = "Siparişe Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.lstYiyeceks);
            this.Controls.Add(this.cmbCesit);
            this.Controls.Add(this.cmbYiyecek);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbYiyecek;
        private System.Windows.Forms.ComboBox cmbCesit;
        private System.Windows.Forms.ListView lstYiyeceks;
        private System.Windows.Forms.Button btnEkle;
    }
}

