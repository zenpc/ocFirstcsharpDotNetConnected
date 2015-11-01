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
            if (nb1 % nb2 > 0) { return false; } return true;
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
            //TODO
        }
        public double ChaineDAdditionsEtDeSoustractionsReelles(string chaine)
        {
            //TODO
        }
        public int ChaineDAdditionsEtSoustractionsEtMultiplicationsEntieres(string chaine)
        {
            //TODO
        }
    }
}
