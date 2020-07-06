namespace bankomat_proekt
{
    partial class Isplata
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
            this.btnOtkazi = new System.Windows.Forms.Button();
            this.btnIsplati = new System.Windows.Forms.Button();
            this.isplataSumaform = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.isplataSumaform)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOtkazi
            // 
            this.btnOtkazi.Location = new System.Drawing.Point(138, 122);
            this.btnOtkazi.Name = "btnOtkazi";
            this.btnOtkazi.Size = new System.Drawing.Size(80, 41);
            this.btnOtkazi.TabIndex = 11;
            this.btnOtkazi.Text = "Откажи";
            this.btnOtkazi.UseVisualStyleBackColor = true;
            this.btnOtkazi.Click += new System.EventHandler(this.btnOtkazi_Click);
            // 
            // btnIsplati
            // 
            this.btnIsplati.Location = new System.Drawing.Point(39, 122);
            this.btnIsplati.Name = "btnIsplati";
            this.btnIsplati.Size = new System.Drawing.Size(84, 41);
            this.btnIsplati.TabIndex = 10;
            this.btnIsplati.Text = "Исплати";
            this.btnIsplati.UseVisualStyleBackColor = true;
            this.btnIsplati.Click += new System.EventHandler(this.btnIsplati_Click);
            // 
            // isplataSumaform
            // 
            this.isplataSumaform.Location = new System.Drawing.Point(48, 76);
            this.isplataSumaform.Maximum = new decimal(new int[] {
            1661992960,
            1808227885,
            5,
            0});
            this.isplataSumaform.Name = "isplataSumaform";
            this.isplataSumaform.Size = new System.Drawing.Size(120, 22);
            this.isplataSumaform.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Исплата на готовина";
            // 
            // Isplata
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 194);
            this.Controls.Add(this.btnOtkazi);
            this.Controls.Add(this.btnIsplati);
            this.Controls.Add(this.isplataSumaform);
            this.Controls.Add(this.label1);
            this.Name = "Isplata";
            this.Text = "Isplata";
            ((System.ComponentModel.ISupportInitialize)(this.isplataSumaform)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOtkazi;
        private System.Windows.Forms.Button btnIsplati;
        private System.Windows.Forms.NumericUpDown isplataSumaform;
        private System.Windows.Forms.Label label1;
    }
}