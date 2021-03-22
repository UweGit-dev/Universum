using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Universum.Planeten;

namespace Universum.GalaxyOne
{
    class AlfaSys : IUnivers
    {
        private Universum universum;
        private Mond mond;
        private Sonne sonne;
        private Erde erde;

        public AlfaSys(Universum universum, Mond mond, Sonne sonne, Erde erd, string i)
        {
            this.universum = universum;
            this.mond = mond;
            this.sonne = sonne;
            this.erde = erd;
            this.universum.alfaSys = this;
            Name = i;
        }

        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Massage { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Massageservice()
        {
            throw new NotImplementedException();
        }
    }
}
