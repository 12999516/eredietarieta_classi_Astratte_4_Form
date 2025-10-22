using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace es
{
    public partial class FFiltra : Form
    {
        public event EventHandler<int> ConfermaFiltra;
        public FFiltra()
        {
            InitializeComponent();
        }

        private void btn_conferma_Click(object sender, EventArgs e)
        {
            int durata = Int32.Parse(lbl_dur.Text);
            DialogResult = DialogResult.OK;
            ConfermaFiltra?.Invoke(this, durata);
        }

        private void lbl_dur_Click(object sender, EventArgs e)
        {

        }

        private void txt_durata_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
