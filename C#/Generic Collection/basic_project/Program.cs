/* Author: Sundar
* 22/03/23
* Description: Simple pgm 1
*/

// Driver

using basic_project;

class Program
{
    public static void Main(string[] args)
    {
        /* Console.WriteLine("Enter Customer id, " + "accno, name, balance ");

         int custid = Convert.ToInt32(Console.ReadLine());
         long accno = Convert.ToInt32(Console.ReadLine());
         string accname = Console.ReadLine();
         decimal balance = Convert.ToDecimal(Console.ReadLine());

         BankTransactions bankTranscations = new BankTransactions(custid, accno, accname, balance);

         bankTranscations.WriteCustomerDetails();*/
        /*int custid = 1; long accno = 3234; string accname = "sundar "; decimal balance = 14423;
        BankTransactions bkdfd = new BankTransactions(custid, accno, accname, balance);
        decimal bal = bkdfd.Performtransactions();
        Console.WriteLine($"Name: {bkdfd.accname}" - " $"Balance: {bal} - "$"Status: {bkdfd.Active}");



        /* Demo2 demo2 = new Demo2();
          demo2.arrdis();*/

        /* Demo2 demo2 = new Demo2();

          int max = Convert.ToInt32(Console.ReadLine());
          int sum = demo2.loopfn(max);
          Console.WriteLine("Total : ", sum);

         string str1 = Console.ReadLine();
         demo2.foreachfn(str1);/*

        /* Console.WriteLine("S ==> 2 numbers M ==> 3 numbers");
             string ch = Console.ReadLine(); 
         switch(ch)
         {
             case "S" or "s":
                 demo2.Big2num();
                 break;
             case "M":
                 demo2.Big3num();
                 break;
             default: Console.WriteLine("Enter S or M");
                 break;



         }*/


        /*using System;

        Console.Write("hello World !");
        Console.WriteLine("hello World !");

        int num1, num2, ans;
        Console.WriteLine("Enter 2 Numbers");

        num1 = Convert.ToInt32(Console.ReadLine());
        num2 = Convert.ToInt32(Console.ReadLine());
        ans = num1 + num2;
        Console.WriteLine("Result: " + ans);*/


        /*int number = 6;
        float flnum = number;
        Console.WriteLine(flnum);

        char ch = Convert.ToChar(number);
        Console.WriteLine(ch);*/

        /*double ans = Math.Sqrt(9);
        Console.WriteLine(ans);

        Console.WriteLine(Math.Equals(ans, ans));*/

        /*string s1 = "Hello Hello World";
        string s2 = "Hello";
        Console.WriteLine(s1.Length);
        Console.WriteLine(s1.Substring(2,6));
        Console.WriteLine(s1.IndexOf('r'));
        Console.WriteLine(s2 + s1);*/

        /*int x = 5;
        int y = 10;
        Console.WriteLine($"{x}_{y}");*/





        //GenericCollection genericCollection = new GenericCollection();
        //genericCollectionsDemo.ListElements();
        //genericCollection.Stackelements();

        //JA ja =new JA();
        //ja.displaymd();

        //LE lE = new LE();
        //lE.evennum();


        /*Customer customer = new Customer(5,"sundar","loan");
        customer.display();

        Console.WriteLine(customer.Custid);
        Console.WriteLine(customer.Custname);
        Console.WriteLine(customer.Acctype);*/

        //Addition addition = new Addition(19, 432);
        //addition.add();

        //Console.WriteLine(addition.add());
        //Console.WriteLine(addition.Num1);

        StaticDemo demo = new StaticDemo();
        demo.disp();
        demo.calc();

        Console.WriteLine(StaticDemo.Amt);

    }
}