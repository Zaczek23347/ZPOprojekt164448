using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zabiegi_SalonFryzjerski
{
    public class BrakDanychException : Exception
    {
        public BrakDanychException(string wiadomosc) : base(wiadomosc)
        {
        }
    }
}
