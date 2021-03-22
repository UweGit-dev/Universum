using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Universum.Planeten;

namespace Universum.GalaxyToo
{
    class BetaSys : IUnivers
    {
        private Universum universum;
        private Mond mondBeta;
        private Sonne sonneBeta;
        private Betaigeutze betaigeutze;

        public BetaSys(Universum universum)
        {
            this.universum = universum;
        }

        public BetaSys(Universum universum, Mond mondBeta, Sonne sonneBeta, Betaigeutze betaigeutze, string i)
        {
            this.mondBeta = mondBeta;
            this.sonneBeta = sonneBeta;
            this.betaigeutze = betaigeutze;
            this.universum = universum;
            this.universum.betaSys = this;
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
