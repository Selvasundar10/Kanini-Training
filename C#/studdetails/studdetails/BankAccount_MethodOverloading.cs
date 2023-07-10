using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studdetails
{
    internal class BankAccount_MethodOverloading
    {
        
        private string name, status;
        double balance;
        int customerid;
        private long accountnumber;

        public BankAccount_MethodOverloading(string name, string status, double balance, int customerid, long accountnumber)
        {
            this.Name = name;
            this.Status = status;
            this.Balance = balance;
            this.Customerid = customerid;
            this.Accountnumber = accountnumber;
        }

        public string Name { get => name; set => name = value; }
        public string Status { get => status; set => status = value; }
        public double Balance { get => balance; set => balance = value; }
        public int Customerid { get => customerid; set => customerid = value; }
        public long Accountnumber { get => accountnumber; set => accountnumber = value; }


        public void checkaccountstatus(int customerid, out string name, out long accountnumber, out double balance, out string status)
        {
            if (customerid == this.Customerid)
            {
                name = Name;
                accountnumber = Accountnumber;
                balance = Balance;
                status = Status;

            }
        }
        public void checkaccountstatus(long accountnumber, out string name, out int customerid, out double balance, out string status)
        {
            if (accountnumber == this.Accountnumber)
            {
                name = Name;
                customerid = Customerid;
                balance = Balance;
                status = Status;

            }
        }
    }
}
    

