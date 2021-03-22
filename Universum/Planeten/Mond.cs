using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universum.Planeten
{
    class Mond : Planet
    {
        private Universum universum;

        public Mond(Universum universum, string i)
        {
            this.universum = universum;
            this.universum.mond = this;
            Name = i;
        }
    }
}
