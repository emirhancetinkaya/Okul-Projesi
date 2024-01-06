namespace udemy15._1_bonusproje
{
    partial class FRMöğretmen
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
            this.btnders = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnSınavNotlar = new System.Windows.Forms.Button();
            this.btnöğrenciişlemleri = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnders
            // 
            this.btnders.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnders.Location = new System.Drawing.Point(54, 48);
            this.btnders.Margin = new System.Windows.Forms.Padding(5);
            this.btnders.Name = "btnders";
            this.btnders.Size = new System.Drawing.Size(304, 63);
            this.btnders.TabIndex = 0;
            this.btnders.Text = "DERS İŞLEMLERİ";
            this.btnders.UseVisualStyleBackColor = true;
            this.btnders.Click += new System.EventHandler(this.btnders_Click);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Location = new System.Drawing.Point(54, 132);
            this.button2.Margin = new System.Windows.Forms.Padding(5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(304, 63);
            this.button2.TabIndex = 1;
            this.button2.Text = "KULÜP İŞLEMLERİ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Location = new System.Drawing.Point(54, 311);
            this.button3.Margin = new System.Windows.Forms.Padding(5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(304, 63);
            this.button3.TabIndex = 2;
            this.button3.Text = "ÖĞRETMENLER";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btnSınavNotlar
            // 
            this.btnSınavNotlar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSınavNotlar.Location = new System.Drawing.Point(54, 216);
            this.btnSınavNotlar.Margin = new System.Windows.Forms.Padding(5);
            this.btnSınavNotlar.Name = "btnSınavNotlar";
            this.btnSınavNotlar.Size = new System.Drawing.Size(304, 63);
            this.btnSınavNotlar.TabIndex = 3;
            this.btnSınavNotlar.Text = "SINAV NOTLARI";
            this.btnSınavNotlar.UseVisualStyleBackColor = true;
            this.btnSınavNotlar.Click += new System.EventHandler(this.btnSınavNotlar_Click);
            // 
            // btnöğrenciişlemleri
            // 
            this.btnöğrenciişlemleri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnöğrenciişlemleri.Location = new System.Drawing.Point(54, 402);
            this.btnöğrenciişlemleri.Margin = new System.Windows.Forms.Padding(5);
            this.btnöğrenciişlemleri.Name = "btnöğrenciişlemleri";
            this.btnöğrenciişlemleri.Size = new System.Drawing.Size(304, 63);
            this.btnöğrenciişlemleri.TabIndex = 4;
            this.btnöğrenciişlemleri.Text = "ÖĞRENCİ İŞLEMLERİ";
            this.btnöğrenciişlemleri.UseVisualStyleBackColor = true;
            this.btnöğrenciişlemleri.Click += new System.EventHandler(this.button5_Click);
            // 
            // FRMöğretmen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(409, 534);
            this.Controls.Add(this.btnöğrenciişlemleri);
            this.Controls.Add(this.btnSınavNotlar);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnders);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FRMöğretmen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRMöğretmen";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnders;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnSınavNotlar;
        private System.Windows.Forms.Button btnöğrenciişlemleri;
    }
}