using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zabiegi_SalonFryzjerski.modele
{
    public class Wizyta
    {
        public int ID { get; set; }
        public string ImieKlienta { get; set; }
        public int ZabiegID { get; set; }
        public DateTime DataWizyty { get; set; }
    }
}
