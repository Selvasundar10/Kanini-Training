/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic_project
{
    public class BankTransactions
    {
        private int custid;
        private long accno;
        private string accname, status;
        private decimal balance, creditamt, debitamt;

        public BankTransactions(long accno)
        {
            this.accno = accno;
        }

        public BankTransactions(int custid, long accno, string accname, decimal balance)
        {
            this.custid = custid; 
            this.accno = accno;
            this.accname = accname;
            this.balance = balance;
            status = "InActive";
            creditamt = debitamt = 0;


        }

        public string Accname { get => accname; set => accname = value; }
        public string Status { get => status; set => status = value; }
        public decimal Balance { get => balance; set => balance = value; }
        public decimal Creditamt { get => creditamt; set => creditamt = value; }
        public decimal Debitamt { get => debitamt; set => debitamt = value; }

        internal decimal Performtransactions() {
           
            Console.WriteLine(" 1. Credit 2. Debit");
            int ch = Convert.ToInt32(Console.ReadLine());
            switch (ch)
            {
                case 1:
                    Console.WriteLine("Enter Credit amt");
                    this.Creditamt = Convert.ToDecimal(Console.ReadLine());
                    this.Balance += creditamt;
                    this.Status = "Active";
                    break;
                case 2:
                    Console.WriteLine("Enter Debit amt");
                    this.Debitamt = Convert.ToDecimal(Console.ReadLine());
                    this.Balance -= debitamt;
                    this.Status = "Active";
                    break;
                default:
                    Console.WriteLine("Enter 1 or 2  ");
                    break;
    
}
            return this.balance;
        }
       
    }
}
*/