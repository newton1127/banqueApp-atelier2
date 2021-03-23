using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanqueApp.classes
{
    class Operation
    {
        private DateTime opdate;
        private int ONum;
        private MAD OMontant;
        private string libelle; 
        

        public Operation(int num , MAD mon , DateTime date , string lib)
        {
            this.OMontant = mon;
            this.ONum = num;
            this.opdate = date;
            this.libelle = lib; 
        }
        public void Operaff()
        {
            Console.WriteLine(this.libelle+"||"+this.opdate + "|| n°" + this.ONum + "||" + this.OMontant.tostring());//add - or + 
        }
    }
}
