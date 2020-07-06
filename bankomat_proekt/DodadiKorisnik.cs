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
 
    public partial class DodadiKorisnik : Form
    {
        public Korisnik korisnik { get; set; }
        public DodadiKorisnik()
        {
            InitializeComponent();
        }

        private void btnVnesi_Click(object sender, EventArgs e)
        {
            korisnik = new Korisnik(tbIme.Text,tbPrezime.Text, tbPIN.Text,0);
            DialogResult = DialogResult.OK;
        }

        private void tbIme_Validating(object sender, CancelEventArgs e)
        {
            if(tbIme.Text.Length == 0)
            {
                errorProvider1.SetError(tbIme,"Внесете име на корисник");
                e.Cancel = true;
            }
            else
            {
                for(int i = 0; i < tbIme.Text.Length; i++)
                {
                   
                    if (!Char.IsLetter(tbIme.Text[i])||!Char.IsUpper(tbIme.Text[0]))
                    {
                       
                        errorProvider1.SetError(tbIme, "Внесеното име да биде со голема буква.");
                        e.Cancel = true ;
                        return;
                    }
                }
                e.Cancel = false;
                errorProvider1.SetError(tbIme,null);


            }
        }

     

        private void tbPrezime_Validating(object sender, CancelEventArgs e)
        {
            if (tbPrezime.Text.Length == 0)
            {
                errorProvider1.SetError(tbPrezime, "Внесете презиме на корисник");
                e.Cancel = true;
            }
            else
            {
                for (int i = 0; i < tbPrezime.Text.Length; i++)
                {

                    if (!Char.IsLetter(tbPrezime.Text[i]) || !Char.IsUpper(tbPrezime.Text[0]))
                    {

                        errorProvider1.SetError(tbPrezime, "Внесеното презиме да биде со голема буква.");
                        e.Cancel = true;
                        return;
                    }
                }
                e.Cancel = false;
                errorProvider1.SetError(tbPrezime, null);


            }
        }

        private void tbPIN_Validating(object sender, CancelEventArgs e)
        {
            if (tbPIN.Text.Length == 0)
            {
                errorProvider1.SetError(tbPIN,"Внесете го пинот");
                e.Cancel = true;
            }
            else
            {
                if (tbPIN.Text.Length < 5 )
                {
                    errorProvider1.SetError(tbPIN, "Пинот треба да содржи повеќе од 5 букви.");
                    e.Cancel = true;
                    return;
                }
                errorProvider1.SetError(tbPIN, null);
                e.Cancel = false;
            }
        }
    }
}
