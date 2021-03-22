using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universum
{
    class Universum
    {
        public Starter program;
        public Planeten.Sonne sonne;
        public Planeten.Mond mond;
        public GalaxyOne.AlfaSys alfaSys;
        public GalaxyOne.Erde erde;
        public Planeten.Sonne betasonne;
        public Planeten.Mond betamond;
        public GalaxyToo.BetaSys betaSys;
        public GalaxyToo.Betaigeutze betaigeutze;


        List<IUnivers> Planetens = new List<IUnivers>();


        internal void Run()
        {
            Planetens.Add(sonne);
            Planetens.Add(mond);
            Planetens.Add(erde);
            Planetens.Add(betasonne);
            Planetens.Add(betamond);
            Planetens.Add(betaigeutze);
            while (true)
            {
                foreach (var item in Planetens)
                {
                    if (item is Planeten.Planet)
                    {
                        item.Massageservice();
                    }
                    else
                    {
                        item.Massageservice();
                    }
                }



            }
        }
    }
    
}
