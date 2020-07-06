namespace bankomat_proekt
{
    partial class Uplata
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
            this.btnotkaziUplata = new System.Windows.Forms.Button();
            this.uplatiBtn = new System.Windows.Forms.Button();
            this.uplataforma = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.uplataforma)).BeginInit();
            this.SuspendLayout();
            // 
            // btnotkaziUplata
            // 
            this.btnotkaziUplata.Location = new System.Drawing.Point(140, 122);
            this.btnotkaziUplata.Name = "btnotkaziUplata";
            this.btnotkaziUplata.Size = new System.Drawing.Size(70, 37);
            this.btnotkaziUplata.TabIndex = 11;
            this.btnotkaziUplata.Text = "Откажи";
            this.btnotkaziUplata.UseVisualStyleBackColor = true;
            this.btnotkaziUplata.Click += new System.EventHandler(this.btnotkaziUplata_Click);
            // 
            // uplatiBtn
            // 
            this.uplatiBtn.Location = new System.Drawing.Point(50, 122);
            this.uplatiBtn.Name = "uplatiBtn";
            this.uplatiBtn.Size = new System.Drawing.Size(72, 37);
            this.uplatiBtn.TabIndex = 10;
            this.uplatiBtn.Text = "Уплати";
            this.uplatiBtn.UseVisualStyleBackColor = true;
            this.uplatiBtn.Click += new System.EventHandler(this.uplatiBtn_Click);
            // 
            // uplataforma
            // 
            this.uplataforma.Location = new System.Drawing.Point(50, 76);
            this.uplataforma.Maximum = new decimal(new int[] {
            -1304428544,
            434162106,
            542,
            0});
            this.uplataforma.Name = "uplataforma";
            this.uplataforma.Size = new System.Drawing.Size(120, 22);
            this.uplataforma.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Уплата на готовина";
            // 
            // Uplata
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 189);
            this.Controls.Add(this.btnotkaziUplata);
            this.Controls.Add(this.uplatiBtn);
            this.Controls.Add(this.uplataforma);
            this.Controls.Add(this.label1);
            this.Name = "Uplata";
            this.Text = "Uplata";
            ((System.ComponentModel.ISupportInitialize)(this.uplataforma)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnotkaziUplata;
        private System.Windows.Forms.Button uplatiBtn;
        private System.Windows.Forms.NumericUpDown uplataforma;
        private System.Windows.Forms.Label label1;
    }
}