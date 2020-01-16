using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnirAsistentModel
{
    public class SudionikModel
    {
        /// <summary>
        /// Ekipa koja ifra utakmicu
        /// </summary>
        public EkipaModel NatjecateljskaEkipa { get; set; }
        /// <summary>
        /// Rezultat ove igre u utakmici
        /// </summary>
        public double Rezultat { get; set; }
        /// <summary>
        /// Prethodna utakmica u kojoj je ova  ekipa bila pobjednik
        /// </summary>
        public UtakmicaModel PrethodnaUtakmica { get; set; }
    }
}
