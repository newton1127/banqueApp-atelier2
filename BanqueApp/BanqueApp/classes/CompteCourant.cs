using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanqueApp.classes
{
    class CompteCourant : Compte
    {
        private static readonly MAD deco = new MAD(1000);
        public CompteCourant(MAD sol, Client N) : base(sol, N)
        {


        }
        public override bool Debiter(MAD M)
        {
            if (M.ispositif())
            {
                if (M < plafond)
                {
                    if (this.solde > M)
                    {
                        if (this.solde - M > deco)
                        {
                            this.solde -= M;
                            DateTime date = DateTime.Now;
                            this.operations.Add(new Operation(this.numcompte, this.solde, date, "débiter"));
                            return true;

                        }
                        else
                        {
                            Console.WriteLine("decouvert depassé");
                            return false;

                        }
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
                Console.WriteLine("veuillez entrer une valeur positif");
                return false;

            }

        }
    }
}
