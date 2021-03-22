using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Universum.Planeten;

namespace Universum.GalaxyOne
{
    class Erde : Planet
    {
        private Universum universum;

        public Erde(Universum universum, string i)
        {
            this.universum = universum;
            this.universum.erde = this;
            Name = i;
        }
    }
}
