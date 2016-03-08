using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerLib
{
    class IAInteligente : IA
    {
        public override int plays(Grid board)
        {
            for (int i = 0; i < board.Nbcolonne; i++)
            {
                int ligne = board.verify(i);
                if(ligne!=-1)
                {
                    
                    if (board.ver(i, ligne, Pion.Yellow,4))
                    {
                        return i;
                    }
                }
                
            }
            Random num = new Random();
            return num.Next(6);
        }
    }
}
