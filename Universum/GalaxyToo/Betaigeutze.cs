using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Universum.Planeten;

namespace Universum.GalaxyToo
{
    class Betaigeutze : Planet
    {
        private Universum universum;

        public Betaigeutze(Universum universum, string i)
        {
            this.universum = universum;
            this.universum.betaigeutze = this;
            Name = i;
        }
    }
}
