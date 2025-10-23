using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace es
{
    public abstract class CElementoMultimediale
    {
        public abstract string Titolo { get; set; }

        public override string ToString()
        {
            return Titolo;
        }
    }
}
