using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerLib
{
    public class Idiot:IA
    {
        public override int plays(Grid board)
        {
            Random num = new Random();
            return num.Next(board.Nbcolonne);
        }
    }
}
