using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zabiegi_SalonFryzjerski.modele
{
    public class Zabieg
    {
        public int ID { get; set; }
        public string Nazwa { get; set; }
        public decimal Cena { get; set; }
        public int CzasTrwaniaMinut { get; set; }
    }
}
