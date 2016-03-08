using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerLib
{
    public abstract class Player
    {
        public String name { get; set; }
        public int nbPion { get; set; }
        public Pion coins { get; set; }
        public IA Inteligence { get; set; }

        public Player(Pion pion,String name,int nbPion)
        {
            coins = pion;
            this.name = name;
            this.nbPion = nbPion;
        }
    }
}
