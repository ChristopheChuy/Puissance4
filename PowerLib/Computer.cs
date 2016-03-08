using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerLib
{
    public class Computer: Player
    {
        public IA Inteligence { get; set; }
        public Computer(Pion pion, int nbPion,int j) : base(pion, pion.ToString(), nbPion) 
        {
            if(j==1)
                Inteligence = new Idiot();
            if (j == 2)
                Inteligence = new IAInteligente();
            if (j == 3)
                Inteligence = new IADefence();
            if (j == 4)
                Inteligence = new IASuperIntelignete___________();
            if (j == 5)
                Inteligence = new IAGodComputer();
        }
    }
}
