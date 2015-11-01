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
            if (nb1 % nb2 > 0) { return true; } return false;
        }

        public int ChaineDAdditionsEntieres(string chaine)
        {
            //TODO
        }

        public double ChaineDAdditionsReelles(string chaine)
        {
            //TODO
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
