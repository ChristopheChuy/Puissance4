using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PowerLib;
using PresentionText;
namespace Power4
{
    class Program
    {
        static void Main(string[] args)
        {
            PresentationTexte presents = new PresentationTexte();
            Game jeu = new Game(presents);
            presents.Menu(jeu);
            jeu.Play();
            while (true) { }
        }
    }
}
