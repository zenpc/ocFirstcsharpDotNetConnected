using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace OC_Calculus_WCFService
{
    public class OperationsArithmetiques : IOperationsArithmetiques
    {
        public double Plus(double nb1, double nb2)
        {
            return (nb1 + nb2);
        }

        public double Moins(double nb1, double nb2)
        {
            return (nb1 - nb2);
        }

        public double Diviser(double nb1, double nb2)
        {
            return (nb1 / nb2);
        }

        public double Multiplier(double nb1, double nb2)
        {
            return (nb1 * nb2);
        }

        public bool EstMultipleDe(int nb1, int nb2)
        {
            if (nb1 % nb2 > 0){
                return false;
            }
            return true;
        }

        public int ChaineDAdditionsEntieres(string chaine)
        {
            int somme = 0 ;
            if (chaine.Length > 0)
            {
                foreach (string val in chaine.Split('+'))
                {
                    if (val != "+")
                    {
                        somme += Convert.ToInt16(val);
                    }
                }
            }
            return somme;
        }

        public double ChaineDAdditionsReelles(string chaine)
        {
            double somme = 0;

            foreach (string val in chaine.Split('+'))
            {
                if (val != "+")
                {
                    somme += Convert.ToInt16(val);
                }

            }
            return somme;
        }
        public int ChaineDAdditionsEtDeSoustractionsEntieres(string chaine)
        {
            int somme = 0;

            List<int> valeurs = new List<int>();

            int taille = 0;
            string nb1 = "", nb2 = "";
            if (chaine == "")
            {
                return somme;
            }

            if (chaine[taille] == '-')
            {
                nb1 += chaine[taille];
                taille++;

            }

            for (; taille < chaine.Length; taille++)
            {

                if (chaine[taille] == '-' || chaine[taille] == '+')
                {

                    int val = Convert.ToInt16(nb1);
                    valeurs.Add(val);
                    nb1 = "";
                    nb1 += chaine[taille];
                }
                else
                {
                    nb1 += chaine[taille];
                }

            }
            valeurs.Add(Convert.ToInt16(nb1));

            foreach (int val in valeurs)
            {
                somme += val;
            }
            return somme;
        }
        public double ChaineDAdditionsEtDeSoustractionsReelles(string chaine)
        {
            double somme = 0;


            List<double> valeurs = new List<double>();

            int taille = 0;
            string nb1 = "", nb2 = "";
            if (chaine == "")
            {
                return somme;
            }

            if (chaine[taille] == '-')
            {
                nb1 += chaine[taille];
                taille++;

            }

            for (; taille < chaine.Length; taille++)
            {
                if (chaine[taille] == '-' || chaine[taille] == '+')
                {
                    double val = Convert.ToDouble(nb1);
                    valeurs.Add(val);
                    nb1 = "";
                    nb1 += chaine[taille];
                }
                else
                {
                    nb1 += chaine[taille];
                }

            }
            valeurs.Add(Convert.ToDouble(nb1));

            foreach (double val in valeurs)
            {
                somme += val;
            }
            return somme;
        }
        public int ChaineDAdditionsEtSoustractionsEtMultiplicationsEntieres(string chaine)
        {
            int somme = 0;

            List<string> valeurs = new List<string>();

            int taille = 0;
            string nb1 = "", nb2 = "";
            if (chaine == "")
            {
                return somme;
            }

            if (chaine[taille] == '-')
            {
                nb1 += chaine[taille];
                taille++;

            }

            for (; taille < chaine.Length; taille++)
            {
                if (chaine[taille] == '*')
                {
                    nb1 += chaine[taille];
                    taille++;
                    if (chaine[taille] == '-')
                    {
                        nb1 += chaine[taille];
                        taille++;
                    }
                }

                if (chaine[taille] == '-' || chaine[taille] == '+')
                {
                    valeurs.Add(nb1);
                    nb1 = "";
                    nb1 += chaine[taille];
                }
                else
                {
                    nb1 += chaine[taille];
                }

            }
            valeurs.Add(nb1);

            // Boucle traitants la chaine pour faire les calculs.
            foreach (string val in valeurs)
            {
                // si val contient le signe de la multiplication on traite differement 
                if (val.Contains('*'))
                {
                    // varriable contenant le résultat des nombres à multiplié 
                    double sommeMulti = 1;
                    // Boucle serrvant à multiplier les nombres 
                    foreach (string nbAMultiplier in val.Split('*'))
                    {
                        // on multiplie les nombres contenu dans la variable val
                        sommeMulti *= Convert.ToDouble(nbAMultiplier);
                    }
                    somme += Convert.ToInt32(sommeMulti);
                }
                // sinon on fait une simple addition (car valeurs contient les nombres à soustraire ou multiplier)
                else
                {
                    somme += Convert.ToInt16(val);
                }
            }
            return somme;

        }
    }
}
