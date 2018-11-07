using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public class Cercle
    {
        public int Rayon { get; set; }
        public Cercle(int rayon)
        {
            this.Rayon = rayon;
        }
        public override string ToString()
        {
            return $"Rayon = {Rayon}";
        }
    }
}
