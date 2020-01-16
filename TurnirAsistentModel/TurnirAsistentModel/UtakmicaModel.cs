using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnirAsistentModel
{
    public class UtakmicaModel
    {
        /// <summary>
        /// Ovo su timovi koji igraju utakmicu
        /// </summary>
        public List<SudionikModel> Natjecatelji { get; set; } = new List<SudionikModel>();
        /// <summary>
        /// Ovo je pobjednik te iste utakmice
        /// </summary>
        public EkipaModel Pobjednik { get; set; }
        /// <summary>
        /// Ovo označava koja je runda u turniru.
        /// </summary>
        public int BrojRunde { get; set; }
    }
}
