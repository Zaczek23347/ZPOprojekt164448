using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zabiegi_SalonFryzjerski.modele;
using Zabiegi_SalonFryzjerski.config;


namespace Zabiegi_SalonFryzjerski
{
 

    public partial class FormZabiegi : Form
    {
        private ZabiegHandler _repozytorium;
        public FormZabiegi()
        {
            InitializeComponent();
            _repozytorium = new ZabiegHandler(AppConfig.Instancja.SciezkaZabiegi);
            OdswiezListe();
        }

        private void OdswiezListe()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = _repozytorium.PobierzWszystkie();
        }

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            var zabieg = new Zabieg
            {
                Nazwa = textBoxNazwa.Text,
                Cena = decimal.Parse(textBoxCena.Text),
                CzasTrwaniaMinuty = int.Parse(textBoxCzas.Text)
            };
            _repozytorium.Dodaj(zabieg);
            OdswiezListe();
        }

        private void buttonUsun_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var zabieg = (Zabieg)dataGridView1.SelectedRows[0].DataBoundItem;
                _repozytorium.Usun(zabieg.ID);
                OdswiezListe();
            }
        }

        private void buttonZapisz_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var zabieg = (Zabieg)dataGridView1.SelectedRows[0].DataBoundItem;
                zabieg.Nazwa = textBoxNazwa.Text;
                zabieg.Cena = decimal.Parse(textBoxCena.Text);
                zabieg.CzasTrwaniaMinuty = int.Parse(textBoxCzas.Text);

                _repozytorium.Edytuj(zabieg);
                OdswiezListe();
            }
        }
        private void dataGridViewZabiegi_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var zabieg = (Zabieg)dataGridView1.SelectedRows[0].DataBoundItem;
                textBoxNazwa.Text = zabieg.Nazwa;
                textBoxCena.Text = zabieg.Cena.ToString();
                textBoxCzas.Text = zabieg.CzasTrwaniaMinuty.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormWizyty formWizyty = new FormWizyty();
            formWizyty.ShowDialog();
        }
    }
}
