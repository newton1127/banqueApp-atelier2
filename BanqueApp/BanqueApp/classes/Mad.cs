using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanqueApp.classes
{
     class MAD
    {
        private double solde;

        public MAD(double solde)
        {
            this.solde = solde;
        }
        public static MAD operator +(MAD M1, MAD M2)
        {
            M1.solde += M2.solde;
            return M1;
        }
        public static MAD operator -(MAD M1, MAD M2)
        {
            M1.solde -= M2.solde;
            return M1;
        }
        public static bool operator >(MAD M1, MAD M2)
        {
            return M1.solde > M2.solde ? true : false;
        }
        public static bool operator <(MAD M1, MAD M2)
        {
            return M1.solde < M2.solde ? true : false;
        }
        public static MAD operator *(MAD M1, double D)
        {
            M1.solde *= D; 
            return M1;
        }
        public void afficher()
        {
            Console.WriteLine("votre solde est " + solde);
        }
        public bool ispositif()
        {
            if (this.solde > 0)
                return (true);
            return false;
        } 
        public string tostring()
        {
            return this.solde.ToString();
        }
    }
}
