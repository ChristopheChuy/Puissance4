using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PowerLib;
namespace PresentionText
{
    public class PresentationTexte : Presentation
    {
        
        public void DisplayGrid(Grid grille)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(" 1 2 3 4 5 6 7");
            Console.Write("\n---------------\n");
            Console.ForegroundColor = ConsoleColor.White;
            for (int i = grille.Nbligne-1; i >=0 ; i--)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("|");
                Console.ForegroundColor = ConsoleColor.White;
                for (int j = 0; j <grille.Nbcolonne; j++)
                {
                    if (grille.TabPion[i, j] == Pion.Red)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;  
                        Console.Write("¤");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    if (grille.TabPion[i, j] == Pion.Yellow)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("¤");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    if (grille.TabPion[i, j] == Pion.empty)
                    {
                        Console.Write(" ");
                    }
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("|");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("\n---------------\n");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }

        public void AjouterDeuxJoueur(Game jeu)
        {
            Console.WriteLine("Saisisez le nom des joueurs :");
            Console.WriteLine("Joueur 1:");
            jeu.AddPlayer(Pion.Red,Console.ReadLine());
            Console.WriteLine("Joueur 2:");
            jeu.AddPlayer(Pion.Yellow, Console.ReadLine());
        }
        public int Jouer(int joueurActif, string name)
        {
            Console.WriteLine("Joueur {0} : {1}", joueurActif,name);
            Console.WriteLine("Dans quelle colonne voulez vous mettre un pion ?");
            return (int.Parse(Console.ReadLine()))-1;
        }
        public void gagner(string name)
        {
            Console.WriteLine("{0} gagne !!!", name);
        }
        public void AjouterUnJoueurEtOrdinateur(Game jeu,int j)
        {
            Console.WriteLine("Saisisez le nom des joueurs :");
            Console.WriteLine("Joueur 1:");
            jeu.AddPlayer(Pion.Red, Console.ReadLine());
            jeu.AddComputer(Pion.Yellow,j);
        }
        public void AjouterDeuxOrdinateur(Game jeu, int j)
        {
            jeu.AddComputer(Pion.Red, j);
            jeu.AddComputer(Pion.Yellow, j);

        }
        public void Menu(Game jeu)
        {
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("|  1. Joueur contre Joueur          |");
            Console.WriteLine("|  2. Joueur contre Ordinateur      |");
            Console.WriteLine("|  3. Ordinateur contre Ordinateur  |");
            Console.WriteLine("-------------------------------------");
            Console.Write("Votre choix : ");
            int i=int.Parse(Console.ReadLine());
            if (i == 1)
                AjouterDeuxJoueur(jeu);
            if (i == 2)
            {
                int j = MenuCom();
                AjouterUnJoueurEtOrdinateur(jeu,j);
            }
            if (i == 3)
            {
                int j = MenuCom();
                AjouterDeuxOrdinateur(jeu, j);
            }
        }
        public int MenuCom()
        {
            Console.Clear();
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("|  1. Ordinateur idiot              |");
            Console.WriteLine("|  2. Ordinateur attaque            |");
            Console.WriteLine("|  3. Ordinateur defend             |");
            Console.WriteLine("|  4. SuperOrdinateur !!!           |");
            Console.WriteLine("|  5. SuperGodOrdinateur !!!        |");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Votre choix");
            return int.Parse(Console.ReadLine());

        }

    }
}
