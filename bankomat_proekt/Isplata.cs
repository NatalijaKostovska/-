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
    public partial class Isplata : Form
    {
        public float isplata { get; set; }
        public Isplata()
        {
            InitializeComponent();
        }

        private void btnIsplati_Click(object sender, EventArgs e)
        {
            isplata = (float)isplataSumaform.Value;
            DialogResult = DialogResult.OK;
        }

        private void btnOtkazi_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
