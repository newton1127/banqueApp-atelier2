using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanqueApp.classes
{
    class CompteEpargne : Compte
    {
        private  double TauxInter; 

        public CompteEpargne(MAD sol, Client N , double tau) : base(sol, N)
        { 
            while (tau < 0 || tau >= 100)
            {
                Console.WriteLine("veuillez vous saisir une valeur entre 0 et 100 !!!");

            }
           this.TauxInter = tau;
            
        } 
        public void CalculInteret()
        {
           this.solde += this.solde *(TauxInter/100);
            
        }
    }
}
