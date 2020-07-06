namespace bankomat_proekt
{
    partial class DodadiKorisnik
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
            this.components = new System.ComponentModel.Container();
            this.btnOtkazi = new System.Windows.Forms.Button();
            this.btnVnesi = new System.Windows.Forms.Button();
            this.lblKorisnik = new System.Windows.Forms.Label();
            this.tbIme = new System.Windows.Forms.TextBox();
            this.tbPrezime = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbPIN = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOtkazi
            // 
            this.btnOtkazi.Location = new System.Drawing.Point(124, 279);
            this.btnOtkazi.Name = "btnOtkazi";
            this.btnOtkazi.Size = new System.Drawing.Size(75, 40);
            this.btnOtkazi.TabIndex = 11;
            this.btnOtkazi.Text = "Откажи";
            this.btnOtkazi.UseVisualStyleBackColor = true;
            // 
            // btnVnesi
            // 
            this.btnVnesi.Location = new System.Drawing.Point(34, 279);
            this.btnVnesi.Name = "btnVnesi";
            this.btnVnesi.Size = new System.Drawing.Size(72, 40);
            this.btnVnesi.TabIndex = 10;
            this.btnVnesi.Text = "Внеси";
            this.btnVnesi.UseVisualStyleBackColor = true;
            this.btnVnesi.Click += new System.EventHandler(this.btnVnesi_Click);
            // 
            // lblKorisnik
            // 
            this.lblKorisnik.AutoSize = true;
            this.lblKorisnik.Location = new System.Drawing.Point(31, 32);
            this.lblKorisnik.Name = "lblKorisnik";
            this.lblKorisnik.Size = new System.Drawing.Size(124, 17);
            this.lblKorisnik.TabIndex = 8;
            this.lblKorisnik.Text = "Додади корисник";
            // 
            // tbIme
            // 
            this.tbIme.Location = new System.Drawing.Point(34, 114);
            this.tbIme.Name = "tbIme";
            this.tbIme.Size = new System.Drawing.Size(165, 22);
            this.tbIme.TabIndex = 12;
            this.tbIme.Validating += new System.ComponentModel.CancelEventHandler(this.tbIme_Validating);
            // 
            // tbPrezime
            // 
            this.tbPrezime.Location = new System.Drawing.Point(34, 173);
            this.tbPrezime.Name = "tbPrezime";
            this.tbPrezime.Size = new System.Drawing.Size(165, 22);
            this.tbPrezime.TabIndex = 13;
            this.tbPrezime.Validating += new System.ComponentModel.CancelEventHandler(this.tbPrezime_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Име";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Презиме";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 17);
            this.label4.TabIndex = 19;
            this.label4.Text = "ПИН";
            // 
            // tbPIN
            // 
            this.tbPIN.Location = new System.Drawing.Point(34, 233);
            this.tbPIN.Name = "tbPIN";
            this.tbPIN.Size = new System.Drawing.Size(165, 22);
            this.tbPIN.TabIndex = 18;
            this.tbPIN.UseSystemPasswordChar = true;
            this.tbPIN.Validating += new System.ComponentModel.CancelEventHandler(this.tbPIN_Validating);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // DodadiKorisnik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 331);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbPIN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbPrezime);
            this.Controls.Add(this.tbIme);
            this.Controls.Add(this.btnOtkazi);
            this.Controls.Add(this.btnVnesi);
            this.Controls.Add(this.lblKorisnik);
            this.Name = "DodadiKorisnik";
            this.Text = "DodadiKorisnik";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOtkazi;
        private System.Windows.Forms.Button btnVnesi;
        private System.Windows.Forms.Label lblKorisnik;
        private System.Windows.Forms.TextBox tbIme;
        private System.Windows.Forms.TextBox tbPrezime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbPIN;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}