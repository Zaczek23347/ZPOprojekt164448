using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

using Zabiegi_SalonFryzjerski.modele;
using Zabiegi_SalonFryzjerski.serwisy;

namespace Zabiegi_SalonFryzjerski
{
    public class ZabiegHandler
    {
        private  string _sciezkaPliku;
        private List<Zabieg> _zabiegi;

        public ZabiegHandler(string sciezkaPliku)
        {
            _sciezkaPliku = sciezkaPliku;
            _zabiegi = JsonService.WczytajZPliku<Zabieg>(_sciezkaPliku);

        }

        public List<Zabieg> PobierzWszystkie()
        { 
            return _zabiegi; 
        }

        public void Dodaj(Zabieg zabieg)
        {
            // nadaje unikalne id
            zabieg.ID = _zabiegi.Any() ? _zabiegi.Max(z => z.ID) + 1 : 1;
            _zabiegi.Add(zabieg);
            Zapisz();
        }

        public void Usun(int ID)
        {
            var zabieg = _zabiegi[ID];
            if (zabieg != null) 
            {
                _zabiegi.Remove(zabieg);
                Zapisz();
            }
        }

        public void Edytuj(Zabieg zabieg)
        {
            var index = _zabiegi.FindIndex(z => z.ID == zabieg.ID);
            if (index != -1)
            {
                _zabiegi[index] = zabieg;
                Zapisz();
            }
        }

        private void Zapisz()
        {
            JsonService.ZapiszDoPliku(_sciezkaPliku, _zabiegi);
        }
    }
}
