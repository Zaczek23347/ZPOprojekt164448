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
    public partial class FormWizyty : Form
    {
        private ZabiegHandler _zabiegRepo;
        private WizytaHandler _wizytaRepo;
        public FormWizyty()
        {
            InitializeComponent();
            _zabiegRepo = new ZabiegHandler(AppConfig.Instancja.SciezkaZabiegi);
            _wizytaRepo = new WizytaHandler(AppConfig.Instancja.SciezkaWizyty);

            comboBoxZabieg.DataSource = _zabiegRepo.PobierzWszystkie();
            comboBoxZabieg.DisplayMember = "Nazwa";
            comboBoxZabieg.ValueMember = "ID";
        }

        private void buttonZapiszWizyte_Click(object sender, EventArgs e)
        {
            try
    {
                if (string.IsNullOrWhiteSpace(textBoxImie.Text))
                    throw new BrakDanychException("Imię klienta jest wymagane.");

                if (comboBoxZabieg.SelectedItem == null)
                    throw new BrakDanychException("Musisz wybrać zabieg.");

                var wizyta = new Wizyta
                {
                    ImieKlienta = textBoxImie.Text,
                    ZabiegID = (int)comboBoxZabieg.SelectedValue,
                    DataWizyty = dateTimePickerData.Value
                };

                _wizytaRepo.Dodaj(wizyta);
                MessageBox.Show("Wizyta zapisana!");
            }
            catch (BrakDanychException ex)
            {
                MessageBox.Show($"Błąd danych: {ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Wystąpił błąd: {ex.Message}", "Błąd krytyczny", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormZabiegi formZabiegi = new FormZabiegi();
            formZabiegi.ShowDialog();
        }
    }
}
