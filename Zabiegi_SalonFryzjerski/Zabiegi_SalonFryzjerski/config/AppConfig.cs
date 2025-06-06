using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zabiegi_SalonFryzjerski.config
{
    public sealed class AppConfig
    {
        private static readonly Lazy<AppConfig> _instancja = new Lazy<AppConfig>(() => new AppConfig());

        public static AppConfig Instancja => _instancja.Value;

        public string SciezkaZabiegi { get; private set; }
        public string SciezkaWizyty { get; private set; }

        private AppConfig()
        {
            SciezkaZabiegi = "zabiegi.json";
            SciezkaWizyty = "wizyty.json";
        }
    }
}
