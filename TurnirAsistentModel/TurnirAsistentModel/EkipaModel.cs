using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnirAsistentModel
{
    public class EkipaModel
    {
        /// <summary>
        /// Ovo će odrediti svaku osobu u timu
        /// </summary>
        public List<OsobaModel> ClanoviEkipe { get; set; } = new List<OsobaModel>();
        /// <summary>
        /// ovo označava ime svake ekipe
        /// </summary>
        public string  ImeEkipe { get; set; }

    }
}

