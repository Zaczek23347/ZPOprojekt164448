using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zabiegi_SalonFryzjerski.modele;
using Zabiegi_SalonFryzjerski.serwisy;

namespace Zabiegi_SalonFryzjerski
{
    public class WizytaHandler
    {
        private readonly string _sciezkaPliku;
        private List<Wizyta> _wizyty;

        public WizytaHandler(string sciezkaPliku)
        {
            _sciezkaPliku = sciezkaPliku;
            _wizyty = JsonService.WczytajZPliku<Wizyta>(_sciezkaPliku);
        }

        public List<Wizyta> PobierzWszystkie() => _wizyty;

        public void Dodaj(Wizyta wizyta)
        {
            wizyta.ID = _wizyty.Any() ? _wizyty.Max(w => w.ID) + 1 : 1;
            _wizyty.Add(wizyta);
            Zapisz();
        }

        private void Zapisz()
        {
            JsonService.ZapiszDoPliku(_sciezkaPliku, _wizyty);
        }
    }
}
