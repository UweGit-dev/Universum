using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universum
{
    class Program
    {

        static void Main(string[] args)
        {

            Universum universum = new Universum();
            Starter star = new Starter(universum);
            universum.Run();
            Console.WriteLine("feddich");
            Console.ReadLine();
        }
        
    }
    class Starter
    {
        Universum universum;
        
        GalaxyOne.AlfaSys alfaSys;
        GalaxyOne.Erde erde;
        Planeten.Mond mond;
        Planeten.Sonne sonne;
        GalaxyToo.BetaSys betaSys;
        GalaxyToo.Betaigeutze betaigeutze;
        Planeten.Mond mondBeta;
        Planeten.Sonne sonneBeta;

        public Starter( Universum u )
        {
            universum = u;
            universum.program = this;

            mond = new Planeten.Mond(universum, "ErdenMond");
            sonne = new Planeten.Sonne(universum, "ErdenSonne");
            erde = new GalaxyOne.Erde(universum, "Erde");
            alfaSys = new GalaxyOne.AlfaSys(universum, mond, sonne, erde,"AlfaSys");


            mondBeta = new Planeten.Mond(universum, "BetaigeutzeMond");
            sonneBeta = new Planeten.Sonne(universum, "BetaigeutzeSonne") ;
            betaigeutze = new GalaxyToo.Betaigeutze(universum, "Betaigeutze");
            betaSys = new GalaxyToo.BetaSys(universum, mondBeta, sonneBeta, betaigeutze, "BetaSys");
        }
    }
}
