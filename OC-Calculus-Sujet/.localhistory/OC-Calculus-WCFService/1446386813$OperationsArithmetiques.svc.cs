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

            if (chaine.Length > 0)
            {
                string[] test = chaine.Split('+');


                for (int i = 0; i < test.Length; i++)
                {
                    if ((i == 0) && (test[i].First() == '-'))
                    {
                        somme += Convert.ToInt16(test[0]);
                        i++;
                    }
                    if (test[i].Contains("-"))
                    {
                        string[] lstMoins = test[i].Split('-');
                        somme += Convert.ToInt16(lstMoins[0]) - Convert.ToInt16(lstMoins[1]);
                    }
                    else
                    {
                        somme += Convert.ToInt16(test[i]);
                    }
                }
            }
            return somme;
        }
        public double ChaineDAdditionsEtDeSoustractionsReelles(string chaine)
        {
            double somme = 0;

            if (chaine.Length > 0)
            {
                string[] test = chaine.Split('+');


                for (int i = 0; i < test.Length; i++)
                {
                    if ((i == 0) && (test[i].First() == '-'))
                    {
                        somme += Convert.ToDouble(test[0]);
                        i++;
                    }
                    if (test[i].Contains("-"))
                    {
                        string[] lstMoins = test[i].Split('-');
                        somme += Convert.ToDouble(lstMoins[0]) - Convert.ToDouble(lstMoins[1]);
                    }
                    else
                    {
                        somme += Convert.ToDouble(test[i]);
                    }
                }
            }
            return somme;
        }
        public int ChaineDAdditionsEtSoustractionsEtMultiplicationsEntieres(string chaine)
        {
            //TODO
        }
    }
}
