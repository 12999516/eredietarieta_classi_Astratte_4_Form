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
    public partial class Fmodifica : Form
    {
        public Fmodifica(CElementoMultimediale[] elementi)
        {
            InitializeComponent();
            cmb_elemento.DataSource = elementi;
        }

        private void modifica(bool lv, bool ad)
        {
            if (cmb_elemento.SelectedItem is CFilmato cFilmato)
            {
                if (lv)
                {
                    if (ad)
                    {
                        cFilmato.brighter();
                    }
                    else
                    {
                        cFilmato.darker();
                    }
                }
                else
                {
                    if (ad)
                    {
                        cFilmato.louder();
                    }
                    else
                    {
                        cFilmato.weaker();
                    }
                }

            }
            else if (cmb_elemento.SelectedItem is CRegistrazioneAudio cMusica)
            {
                if (lv)
                {
                    if (ad)
                    {
                        cMusica.louder();
                    }
                    else
                    {
                        cMusica.weaker();
                    }
                }

                if (ad)
                {
                    cMusica.louder();
                }
                else
                {
                    cMusica.weaker();
                }
            }
            else if(cmb_elemento.SelectedItem is CImmagine cimmgine)
            {
                if(ad)
                {
                    cimmgine.brighter();
                }
                else
                {
                    cimmgine.darker();
                }
            }
            else
            {
                MessageBox.Show("seleziona un elemento valido");
            }
        }

        private void btn_Aumenta_Click(object sender, EventArgs e)
        {
             if (rdb_luminosita.Checked && cmb_elemento.SelectedItem != null)
            {
                modifica(true, true);
            }
            else if (rdb_volume.Checked && cmb_elemento.SelectedItem != null)
            {
                modifica(false, true);
            }
            else
            {
                MessageBox.Show("controllare i campi");
            }
        }

        private void btn_decrementa_Click(object sender, EventArgs e)
        {
            if (rdb_luminosita.Checked && cmb_elemento.SelectedItem != null)
            {
                modifica(true, false);
                DialogResult = DialogResult.OK;
            }
            else if (rdb_volume.Checked && cmb_elemento.SelectedItem != null)
            {
                modifica(false, false);
                DialogResult = DialogResult.OK;
            }
        }
    }
}
