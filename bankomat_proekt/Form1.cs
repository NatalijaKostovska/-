using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bankomat_proekt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnIsplata_Click(object sender, EventArgs e)
        {
            Isplata i = new Isplata();
            if (i.ShowDialog() == DialogResult.OK)
            {
                Korisnik selektiranKorisnik = (Korisnik)lbkorisnici.SelectedItem;
                if(selektiranKorisnik.suma < i.isplata)
                {
                    lblgreska.Show();
                   
                }
                else
                {
                 selektiranKorisnik.suma = selektiranKorisnik.suma - i.isplata;
                 gotovinatb.Clear();
                }
               
                
            }
        }

        private void btnDodadiKorisnik_Click(object sender, EventArgs e)
        {
            DodadiKorisnik dk = new DodadiKorisnik();
            if (dk.ShowDialog() == DialogResult.OK)
            {
                lbkorisnici.Items.Add(dk.korisnik);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (lbkorisnici.SelectedIndex != -1)
            {
              
                Korisnik selektiranKorisnik = (Korisnik)lbkorisnici.SelectedItem;
                if (selektiranKorisnik.pin == tbPIN.Text)
                {
                    btnPregled.Show();
                    btnUplata.Show();
                    btnIsplata.Show();
                    odjavabtn.Show();
                    najavenlbl.Show();
                    groupBox1.Hide();
                    btnDodadiKorisnik.Hide();
                }
               
            }
        }

        private void tbPIN_Validating(object sender, CancelEventArgs e)
        {
            Korisnik selektiranKorisnik = (Korisnik)lbkorisnici.SelectedItem;
            if (selektiranKorisnik.pin != tbPIN.Text)
            {
                errorProvider1.SetError(tbPIN, "Погрешен пин");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(tbPIN, null);
                e.Cancel = false;
            }
        }

        private void btnPregled_Click(object sender, EventArgs e)
        {
            Korisnik selektiranKorisnik = (Korisnik)lbkorisnici.SelectedItem;

            gotovinatb.Text = Convert.ToString(selektiranKorisnik.suma);
            gotovinatb.Show();
            gotovina.Show();
            


        }

        private void btnUplata_Click(object sender, EventArgs e)
        {
            Uplata u = new Uplata();
            if (u.ShowDialog() == DialogResult.OK)
            {
                Korisnik selektiranKorisnik = (Korisnik)lbkorisnici.SelectedItem;
                selektiranKorisnik.suma = selektiranKorisnik.suma + u.uplata;
                gotovinatb.Clear();
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            najavenlbl.Hide();
            groupBox1.Show();
            btnPregled.Hide();
            gotovina.Hide();
            gotovinatb.Hide();
            btnIsplata.Hide();
            btnUplata.Hide();
            tbPIN.Clear();
            btnDodadiKorisnik.Show();


        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }
    }
}
