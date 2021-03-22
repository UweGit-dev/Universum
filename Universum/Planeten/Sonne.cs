using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Universum.Planeten;
namespace Universum.Planeten
{
    class Sonne : Planet
    {
        private Universum universum;

        public Sonne(Universum universum, string i)
        {
            this.universum = universum;
            this.universum.sonne = this;
            Name = i;
        }
    }
}
