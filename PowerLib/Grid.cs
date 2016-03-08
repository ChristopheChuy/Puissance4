using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerLib
{
    public class Grid
    {
        public Pion[,] TabPion { get; set; }
        public int Nbligne { get; set; }
        public int Nbcolonne { get; set; }
        public int Col { get; set; }
        public int Ligne { get; set; }

        public Grid(int nbligne, int nbcolonne)
        {
            this.Nbligne = nbligne;
            this.Nbcolonne = nbcolonne;
            TabPion = new Pion[nbligne, nbcolonne];
            for (int i = 0; i < nbcolonne; i++)
                for (int j = 0; j < nbligne; j++)
                    TabPion[j, i] = Pion.empty;
        }

        public int addPion(int colonne, Player joueur)
        {
            int ligne = verify(colonne);
            if (ligne == -1)
                return -1;
            TabPion[ligne, colonne] = joueur.coins;
            return ligne;
        }

        public int verify(int colonne)
        {
            for (int j = 0; j < Nbligne; j++)
                if (TabPion[j, colonne] == Pion.empty)
                    return j;
            return -1;
        }

        public bool TestLigne(int col, int ligne, Pion pion, int ParRaportA)
        {
            int NbPions = 1;
            for (int i = col+1; i <= 6; i++)
                if (TabPion[ligne, i] == pion)
                    NbPions++;
                else break;
            for (int j = col-1; j >= 0; j--)
                if (TabPion[ligne, j] == pion)
                    NbPions++;
                else break;
            return NbPions >= ParRaportA;
        }

        public bool TestColonne(int col, int ligne, Pion pion, int ParRaportA)
        {
            int NbPions = 1;
            for (int i = ligne+1; i <= 5; i++)
                if (TabPion[i, col] == pion)
                    NbPions++;
                else break;
            for (int j = ligne-1; j >= 0; j--)
                if (TabPion[j, col] == pion)
                    NbPions++;
                else break;
            return NbPions >= ParRaportA;
        }

        public bool TestDiagDroite(int col, int ligne, Pion pion, int ParRaportA)
        {
            int NbPions = 1;
            for (int i = ligne+1, j = col+1; i < 6 && j < 7; i++, j++)
            {
                if (TabPion[i, j] == pion)
                    NbPions++;
                else i = 6;
            }
            for (int i = ligne-1, j = col-1; i > -1 && j > -1; i--, j--)
            {
                if (TabPion[i, j] == pion)
                    NbPions++;
                else i = -1;
            }
            return NbPions >= ParRaportA;
        }

        public bool TestDiagGauche(int col, int ligne, Pion pion, int ParRaportA)
        {
            int NbPions = 0;
            for (int i = ligne, j = col; i < 6 && j > -1; i++, j--)
            {
                if (TabPion[i, j] == pion)
                    NbPions++;
                else i = 6;
            }
            for (int i = ligne, j = col; i > -1 && j < 6; i--, j++)
            {
                if (TabPion[i, j] == pion)
                    NbPions++;
                else i = -1;
            }
            return NbPions >= ParRaportA;
        }

        public bool ver(int col, int ligne, Pion pion,int ParRaportA)
        {
            if (TestLigne(col, ligne, pion, ParRaportA)) return true;
            if (TestColonne(col, ligne, pion, ParRaportA)) return true;
            if (TestDiagDroite(col, ligne, pion, ParRaportA)) return true;
            if (TestDiagGauche(col, ligne, pion, ParRaportA)) return true;
            return false;
        }
    }
}