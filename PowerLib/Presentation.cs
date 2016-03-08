using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerLib
{
    public interface Presentation
    {
        void DisplayGrid(Grid grille);
        void AjouterDeuxJoueur(Game jeu);
        int Jouer(int joueurActif, string name);
        void gagner(string name);
    }
}
