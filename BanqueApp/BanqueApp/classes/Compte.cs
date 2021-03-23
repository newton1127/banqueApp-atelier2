using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanqueApp.classes
{
     class Compte
    {
        
        private static int compt = 0;
        protected   int numcompte;
        protected MAD solde;
        protected readonly Client titulaire;
        protected static MAD plafond = new MAD(7000);
        protected List<Operation> operations = new List<Operation>();
        public Compte(MAD sol, Client N)
        {
            this.solde = sol;
            compt++;
            numcompte = compt;
            this.titulaire = N;
        }
        public virtual void Afficher()
        {
            Console.WriteLine(" Numero de votre compte : " + numcompte);
           for (int i =0; i < operations.Count(); i++)
            {
                operations[i].Operaff();
            }
            solde.afficher();
            titulaire.afficher();
        }

        void Crediter(MAD M)
        {
            if (M.ispositif() )
            {
                this.solde += M;
                Console.WriteLine(" done !!!");
                DateTime date = DateTime.Now;
                this.operations.Add(new Operation(this.numcompte, this.solde, date, "creéditer"));
            }
            else
                Console.WriteLine("veuillez entrer une valeur positive");
        } 
        public virtual bool Debiter(MAD M)
        {
            if (M.ispositif())
            {
                if (M < plafond)
                {
                    if (this.solde > M)
                    { 
                        this.solde -= M;
                        DateTime date = DateTime.Now;
                        this.operations.Add(new Operation(this.numcompte, this.solde, date, "débiter")); 
                        
                        return true;
                    }
                    else
                    {
                        Console.WriteLine("solde insuffisant");
                        return false;

                    }
                }
                else
                {
                    Console.WriteLine("plafond depassé");
                    return false;

                }
            }
            else
            {
                Console.WriteLine("veuillez entrer une valeur positive");
                return false;

            }

        }
        public void Virement(Compte C1, MAD M)
        {
            if (this.Debiter(M))
                C1.Crediter(M);
            DateTime date = DateTime.Now;
            this.operations.Add(new Operation(this.numcompte, this.solde, date, "virement"));
        }
    }
}
