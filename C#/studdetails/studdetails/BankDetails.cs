using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studdetails
{
    internal abstract class BankDetails
    {
        int accno;
        string accname;
        double balance;
        double interest;


        public BankDetails(int accno, string accname, double balance)
        {
            this.Accno = accno; 
            this.Accname = accname;
            this.Balance = balance;
        }

        public int Accno { get => accno; set => accno = value; }
        public string Accname { get => accname; set => accname = value; }
        public double Balance { get => balance; set => balance = value; }
        public double Interest { get => interest; set => interest = value; }


        public abstract double CalculateInterest();

    }

}
