namespace bankomat_proekt
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
            this.components = new System.ComponentModel.Container();
            this.btnPregled = new System.Windows.Forms.Button();
            this.btnIsplata = new System.Windows.Forms.Button();
            this.btnUplata = new System.Windows.Forms.Button();
            this.btnDodadiKorisnik = new System.Windows.Forms.Button();
            this.lbkorisnici = new System.Windows.Forms.ListBox();
            this.gotovina = new System.Windows.Forms.Label();
            this.gotovinatb = new System.Windows.Forms.TextBox();
            this.tbPIN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.odjavabtn = new System.Windows.Forms.Button();
            this.najavenlbl = new System.Windows.Forms.Label();
            this.lblgreska = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPregled
            // 
            this.btnPregled.BackColor = System.Drawing.Color.SkyBlue;
            this.btnPregled.Location = new System.Drawing.Point(29, 210);
            this.btnPregled.Name = "btnPregled";
            this.btnPregled.Size = new System.Drawing.Size(170, 48);
            this.btnPregled.TabIndex = 0;
            this.btnPregled.Text = "Преглед на готовина";
            this.btnPregled.UseVisualStyleBackColor = false;
            this.btnPregled.Visible = false;
            this.btnPregled.Click += new System.EventHandler(this.btnPregled_Click);
            // 
            // btnIsplata
            // 
            this.btnIsplata.BackColor = System.Drawing.Color.SkyBlue;
            this.btnIsplata.Location = new System.Drawing.Point(29, 331);
            this.btnIsplata.Name = "btnIsplata";
            this.btnIsplata.Size = new System.Drawing.Size(169, 48);
            this.btnIsplata.TabIndex = 1;
            this.btnIsplata.Text = "Исплата на средства";
            this.btnIsplata.UseVisualStyleBackColor = false;
            this.btnIsplata.Visible = false;
            this.btnIsplata.Click += new System.EventHandler(this.btnIsplata_Click);
            // 
            // btnUplata
            // 
            this.btnUplata.BackColor = System.Drawing.Color.SkyBlue;
            this.btnUplata.Location = new System.Drawing.Point(30, 385);
            this.btnUplata.Name = "btnUplata";
            this.btnUplata.Size = new System.Drawing.Size(169, 47);
            this.btnUplata.TabIndex = 2;
            this.btnUplata.Text = "Уплата на средства";
            this.btnUplata.UseVisualStyleBackColor = false;
            this.btnUplata.Visible = false;
            this.btnUplata.Click += new System.EventHandler(this.btnUplata_Click);
            // 
            // btnDodadiKorisnik
            // 
            this.btnDodadiKorisnik.Location = new System.Drawing.Point(29, 68);
            this.btnDodadiKorisnik.Name = "btnDodadiKorisnik";
            this.btnDodadiKorisnik.Size = new System.Drawing.Size(170, 50);
            this.btnDodadiKorisnik.TabIndex = 3;
            this.btnDodadiKorisnik.Text = "Додади корисник";
            this.btnDodadiKorisnik.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnDodadiKorisnik.UseVisualStyleBackColor = true;
            this.btnDodadiKorisnik.Click += new System.EventHandler(this.btnDodadiKorisnik_Click);
            // 
            // lbkorisnici
            // 
            this.lbkorisnici.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbkorisnici.FormattingEnabled = true;
            this.lbkorisnici.ItemHeight = 16;
            this.lbkorisnici.Location = new System.Drawing.Point(221, 68);
            this.lbkorisnici.Name = "lbkorisnici";
            this.lbkorisnici.Size = new System.Drawing.Size(238, 116);
            this.lbkorisnici.TabIndex = 4;
            // 
            // gotovina
            // 
            this.gotovina.AutoSize = true;
            this.gotovina.Location = new System.Drawing.Point(27, 266);
            this.gotovina.Name = "gotovina";
            this.gotovina.Size = new System.Drawing.Size(70, 17);
            this.gotovina.TabIndex = 5;
            this.gotovina.Text = "Готовина";
            this.gotovina.Visible = false;
            // 
            // gotovinatb
            // 
            this.gotovinatb.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gotovinatb.Location = new System.Drawing.Point(30, 286);
            this.gotovinatb.Name = "gotovinatb";
            this.gotovinatb.Size = new System.Drawing.Size(98, 22);
            this.gotovinatb.TabIndex = 6;
            this.gotovinatb.Visible = false;
            // 
            // tbPIN
            // 
            this.tbPIN.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbPIN.Location = new System.Drawing.Point(9, 63);
            this.tbPIN.Name = "tbPIN";
            this.tbPIN.Size = new System.Drawing.Size(92, 22);
            this.tbPIN.TabIndex = 7;
            this.tbPIN.UseSystemPasswordChar = true;
            this.tbPIN.Validating += new System.ComponentModel.CancelEventHandler(this.tbPIN_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Внеси пин";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(9, 105);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 28);
            this.button1.TabIndex = 9;
            this.button1.Text = "Најави се";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.najavenlbl);
            this.groupBox1.Controls.Add(this.tbPIN);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(221, 210);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(238, 254);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Најавување на корисникот";
            // 
            // odjavabtn
            // 
            this.odjavabtn.BackColor = System.Drawing.Color.IndianRed;
            this.odjavabtn.Font = new System.Drawing.Font("Segoe UI Symbol", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.odjavabtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.odjavabtn.Location = new System.Drawing.Point(561, 483);
            this.odjavabtn.Name = "odjavabtn";
            this.odjavabtn.Size = new System.Drawing.Size(114, 30);
            this.odjavabtn.TabIndex = 10;
            this.odjavabtn.Text = "Одјави се";
            this.odjavabtn.UseVisualStyleBackColor = false;
            this.odjavabtn.Visible = false;
            this.odjavabtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // najavenlbl
            // 
            this.najavenlbl.AutoSize = true;
            this.najavenlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.najavenlbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.najavenlbl.Location = new System.Drawing.Point(9, 142);
            this.najavenlbl.Name = "najavenlbl";
            this.najavenlbl.Size = new System.Drawing.Size(140, 17);
            this.najavenlbl.TabIndex = 10;
            this.najavenlbl.Text = "Успешно најавен!";
            this.najavenlbl.Visible = false;
            // 
            // lblgreska
            // 
            this.lblgreska.AutoSize = true;
            this.lblgreska.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgreska.ForeColor = System.Drawing.Color.Brown;
            this.lblgreska.Location = new System.Drawing.Point(171, 483);
            this.lblgreska.Name = "lblgreska";
            this.lblgreska.Size = new System.Drawing.Size(349, 17);
            this.lblgreska.TabIndex = 13;
            this.lblgreska.Text = "Немате доволно средства на вашата сметка.";
            this.lblgreska.Visible = false;
            this.lblgreska.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(692, 529);
            this.Controls.Add(this.lblgreska);
            this.Controls.Add(this.odjavabtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gotovinatb);
            this.Controls.Add(this.gotovina);
            this.Controls.Add(this.lbkorisnici);
            this.Controls.Add(this.btnDodadiKorisnik);
            this.Controls.Add(this.btnUplata);
            this.Controls.Add(this.btnIsplata);
            this.Controls.Add(this.btnPregled);
            this.Name = "Form1";
            this.Text = "Банкомат";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPregled;
        private System.Windows.Forms.Button btnIsplata;
        private System.Windows.Forms.Button btnUplata;
        private System.Windows.Forms.Button btnDodadiKorisnik;
        private System.Windows.Forms.ListBox lbkorisnici;
        private System.Windows.Forms.Label gotovina;
        private System.Windows.Forms.TextBox gotovinatb;
        private System.Windows.Forms.TextBox tbPIN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button odjavabtn;
        private System.Windows.Forms.Label najavenlbl;
        private System.Windows.Forms.Label lblgreska;
    }
}

