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
    public partial class Form1 : Form
    {
        CElementoMultimediale[] elementi;
        public Form1()
        {
            InitializeComponent();
            elementi = new CElementoMultimediale[5];
            elementi[0] = (new CRegistrazioneAudio("Audio Lezione", 4, 7));
            elementi[1] = (new CImmagine("Foto Matrimonio"));
            elementi[2] = (new CImmagine("Foto Vacanza"));
            elementi[3] = (new CFilmato("Video Compleanno", 5, 3));
            elementi[4] = (new CFilmato("Video Viaggio", 3, 2));
            dtg_visualizza.DataSource = elementi;
            cmb_scelta_1.Visible = false;
            cmb_scelta_2.Visible = false;
            lbl_seleziona.Visible = false;
        }

        private void btn_ordina_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < elementi.Length - 1; i++)
            {
                for (int j = 0; j < elementi.Length - i - 1; j++)
                {
                    if (elementi[j].Titolo == elementi[j + 1].Titolo)
                    {
                        CElementoMultimediale temp = elementi[j];
                        elementi[j] = elementi[j + 1];
                        elementi[j + 1] = temp;
                    }
                }
            }
            dtg_visualizza.DataSource = null;
            dtg_visualizza.DataSource = elementi;
        }

        private void btn_modifica_Click(object sender, EventArgs e)
        {
            using (Fmodifica fm = new Fmodifica(elementi))
            {
                fm.ShowDialog();
            }
        }

        private void btn_compara_Click(object sender, EventArgs e)
        {
            lbl_seleziona.Text += "film";
            cmb_scelta_1.DataSource = elementi;
            cmb_scelta_2.DataSource = elementi;
            cmb_scelta_2.Visible = true;
            cmb_scelta_1 .Visible = true;

            if (cmb_scelta_1.SelectedItem != null && cmb_scelta_2.SelectedItem != null && cmb_scelta_1.SelectedItem != cmb_scelta_2.SelectedItem)
            {
                
                CElementoMultimediale selezione1 = (CElementoMultimediale)cmb_scelta_1.SelectedItem;
                CElementoMultimediale selezione2 = (CElementoMultimediale)cmb_scelta_2.SelectedItem;

                if (selezione1 is CFilmato filmato1 && selezione2 is CFilmato filmato2)
                {
                    MessageBox.Show(filmato1.uguale(filmato2));
                }
                else
                {
                    MessageBox.Show("errore di inserimento");
                }
            }
        }

        private void btn_esegui_Click(object sender, EventArgs e)
        {
            cmb_scelta_1.Visible = true;
            lbl_seleziona.Text = "Seleziona elemento multimediale da eseguire:";
            cmb_scelta_1.DataSource = elementi;
            if (cmb_scelta_1.SelectedItem != null)
            {
                if (cmb_scelta_1.SelectedItem is CFilmato cfilmato)
                {
                    MessageBox.Show(cfilmato.play());
                }
                else if (cmb_scelta_1.SelectedItem is CRegistrazioneAudio cmusica)
                {
                    MessageBox.Show(cmusica.play());
                }
                else if (cmb_scelta_1.SelectedItem is CImmagine cimmagine)
                {
                    MessageBox.Show(cimmagine.show());

                }
            }
        }

        private void btn_filtra_Click(object sender, EventArgs e)
        {
            using (FFiltra ff = new FFiltra())
            {
                ff.ConfermaFiltra += ffiltra_filtra;
                ff.ShowDialog();
            }
        }

        private void ffiltra_filtra(object sender, int durata)
        {
            List<CElementoMultimediale> ce = new List<CElementoMultimediale>();
            for(int i = 0; i < elementi.Length; i++)
            {
                if (elementi[i] is CFilmato cFilmato)
                {
                    if(cFilmato.durata <= durata)
                    {
                        ce.Add(cFilmato);
                    }
                }
            }
            dtg_visualizza.DataSource = null;
            dtg_visualizza.DataSource = ce;
        }
    }
}
