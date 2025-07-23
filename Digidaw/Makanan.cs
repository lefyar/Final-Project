using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digidaw
{
    public class Makanan
    {
        public string Nama { get; set; }
        public int KaloriPerPorsi { get; set; }
        public int ProteinPerPorsi { get; set; }

        public Makanan(string nama, int kalori, int protein)
        {
            Nama = nama;
            KaloriPerPorsi = kalori;
            ProteinPerPorsi = protein;
        }
    }
}
