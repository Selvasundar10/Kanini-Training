
using studdetails;
using System.Security.Cryptography;
using System.Xml.Linq;

class Program

{
    public static void Main(string[] args)
    {
        /*

        Console.WriteLine("Enter roll number,name and 3 marks");
        int rno = Convert.ToInt32(Console.ReadLine());
        string name = Console.ReadLine();
        double mark1 = Convert.ToDouble(Console.ReadLine());
        double mark2 = Convert.ToDouble(Console.ReadLine());
        double mark3 = Convert.ToDouble(Console.ReadLine());
        studcalculation StudCalculation = new studcalculation(rno, name, mark1, mark2, mark3, 0, 0);
        StudCalculation.Calculation();
        Console.WriteLine($"Roll number : {StudCalculation.Rno}\n Name : {StudCalculation.Name}\n Total : {StudCalculation.Tot}\n Average : {StudCalculation.Avg}");*/

        /* Console.WriteLine("Enter collegename, addr, pin");
         string collegename  = Console.ReadLine();
         string address = Console.ReadLine();
         double pin = Convert.ToDouble(Console.ReadLine());

         Console.WriteLine("eid ,name,dept,fav sub,sal ");
         int eid = Convert.ToInt32(Console.ReadLine());
         string name = Console.ReadLine();
         string dept = Console.ReadLine();
         string favsub = Console.ReadLine();
         double salary = Convert.ToDouble(Console.ReadLine());

         Console.WriteLine(" EID, name, sal");
         int aeid = Convert.ToInt32(Console.ReadLine());
         string aname = Console.ReadLine();
         double asalary = Convert.ToDouble (Console.ReadLine());

         TeachingStaff teaching_staff = new TeachingStaff( collegename,  address,  pin,  eid,  name,  dept,  favsub,  salary);

         AdminStaff admin_staff = new AdminStaff(collegename, address, pin, aeid, aname, asalary);

         double tsal = teaching_staff.calculatesalary();
         double asal = admin_staff.calculatesalary();

         Console.WriteLine("College Name" + teaching_staff.Collegename + " TS EMP name " + teaching_staff.Name + "TS salary" + tsal + "AS Emp name " + admin_staff.Name + "As Salary " + asal);

         */

        /*Console.WriteLine("Enter two number");
        Addition addition = new Addition();
        int n3 =10; int n4 =10;
       addition.add(n3, n4, out int n1,out int n2);
      Console.WriteLine(n1 + " " + n2);*/

        BankAccount_MethodOverloading bankAccount_MethodOverloading = new BankAccount_MethodOverloading("sathya", "InActive", 13.5, 1234, 68378929827);
        Console.WriteLine("1. Custid 2.AccNo :");
        int ch = Convert.ToInt32(Console.ReadLine());
        switch (ch)
        {
            case 1:
                bankAccount_MethodOverloading.checkaccountstatus(1234, out string name, out long accountnumber, out double balance, out string status);
                Console.WriteLine($"Account Number : {accountnumber} \n Name : {name}\n Balance : {balance}\n Status : {status}");
                break;
            case 2:
                bankAccount_MethodOverloading.checkaccountstatus(68378929827, out name, out int customerid, out balance, out status);
                Console.WriteLine($"Customer ID : {customerid} \n Name : {name}\n Balance : {balance}\n Status : {status}");

                break;
            default:
                Console.WriteLine("Emter 1 Or 2");
                break;

        }
    }
}