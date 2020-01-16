using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnirAsistentModel
{
    public class TurnirModel
    {
        /// <summary>
        /// Ovo je ime turnira koji se igra
        /// </summary>
        public string NazivTurnira { get; set; }
        /// <summary>
        /// Ovo označava količinu novca potrebnu za ulazak u turnir
        /// </summary>
        public decimal Kotizacija { get; set; }
        /// <summary>
        /// Ovo su svi timovi koji su se prijavili u turnir
        /// </summary>
        public List<EkipaModel> PrijavljeniTimovi { get; set; } = new List<EkipaModel>();
        /// <summary>
        /// Ovo je lista svih nagrada u turniru
        /// </summary>
        public List<NagradaModel> Nagrade { get; set; } = new List<NagradaModel>();
        /// <summary>
        /// Runda je sama po sebi lista a turnir je lista sama za sebe
        /// </summary>
        public List<List<UtakmicaModel>> Runde { get; set; } = new List<List<UtakmicaModel>>();
    }
}
