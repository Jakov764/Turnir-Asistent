using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnirAsistentModel
{
    public class NagradaModel
    {
        /// <summary>
        /// Ovo označava mjesto na koje dođe svaki tim
        /// </summary>
        public int OsvojenoMjesto { get; set; }
        /// <summary>
        /// Ovo je ime tog istog mjesta
        /// </summary>
        public string NazivMjesta { get; set; }
        /// <summary>
        /// Ovo označava novčanu količinu novca koji se dobiva uz određeno mjesto
        /// </summary>
        public decimal IznosNagrade { get; set; }
        /// <summary>
        /// Ovo označava novčanu postotak koji se dobiva uz određeno mjesto
        /// </summary>
        public double PostotakNagrade { get; set; }
    }
}
