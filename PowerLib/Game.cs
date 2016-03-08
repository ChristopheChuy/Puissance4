using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerLib
{
    public class Game
    {
        public Grid board {get; set; }
        public Presentation presents { get; set; }
        public Player[] thePlayer { get; set; }
        public int JoueurActif { get; set; }
        public int NbJoueur { get; set; }

        public Game(Presentation pre)
        {
            thePlayer = new Player[2];
            JoueurActif = 0;
            board = new Grid(6, 7);
            presents = pre;
        }

        public int joueurActif()
        {
            return (JoueurActif + 1) % 2;
        }

        public void AddPlayer(Pion pion, String name)
        {
            if (NbJoueur < 3)
            {
                thePlayer[NbJoueur] = new Humain(pion, name, 21);
                NbJoueur++;
            }
        }

        public void AddComputer(Pion pion,int j){
            thePlayer[NbJoueur]=new Computer(pion,21,j);
            NbJoueur++;
        }

        public void Play()
        {
            int col;
            int verif;
            bool veriff = false;
            presents.DisplayGrid(board);
            while (!veriff)
            {
                if (thePlayer[JoueurActif].GetType() == typeof(Computer))
                {
                    col = ((Computer)thePlayer[JoueurActif]).Inteligence.plays(board);
                    verif = board.addPion(col, thePlayer[JoueurActif]);
                    while (verif == -1)
                    {
                        col = thePlayer[JoueurActif].Inteligence.plays(board);
                        verif = board.addPion(col, thePlayer[JoueurActif]); ;
                    }
                }
                else
                {
                    col = presents.Jouer(JoueurActif + 1, thePlayer[JoueurActif].name);
                    verif = board.addPion(col, thePlayer[JoueurActif]);
                    while (verif == -1)
                    {
                        col = presents.Jouer(JoueurActif + 1, thePlayer[JoueurActif].name);
                        verif = board.addPion(col, thePlayer[JoueurActif]); ;
                    }
                }
                presents.DisplayGrid(board);
                board.Col = col;
                board.Ligne = verif;
                veriff = board.ver(col, verif, thePlayer[JoueurActif].coins,4);
                JoueurActif = joueurActif();
            }
            JoueurActif = joueurActif();
            presents.gagner(thePlayer[JoueurActif].name);
            
        }
    }
}
