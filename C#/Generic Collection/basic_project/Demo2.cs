using System;
class Demo2
{
    /*public void Big2num()
    {
        int num1, num2;
        Console.WriteLine("Enter two numbers");
        num1 = Convert.ToInt32(Console.ReadLine());
        num2 = Convert.ToInt32(Console.ReadLine());
        if (num1 == num2)
            Console.WriteLine("Both are equal");
        else if (num2 > num1)
            Console.WriteLine(num2 + " is big");
        else
            Console.WriteLine(num1 + " is big");
    }
    public void Big3num()
    {
        int num1, num2, num3;
        Console.WriteLine("Enter three numbers");
        num1 = Convert.ToInt32(Console.ReadLine());
        num2 = Convert.ToInt32(Console.ReadLine());
        num3 = Convert.ToInt32(Console.ReadLine());
        if ((num1 == num2) && (num2==num3))
            Console.WriteLine("Both are equal");
            else if ((num1 > num2) && (num1 >num3))
            Console.WriteLine(num2 + " is big");
        else if ((num2 > num1) && (num2 > num1))
            Console.WriteLine(num2 + " is big");
        else
            Console.WriteLine(num3 + " is big");
    }*/
    /*public void loopfn()
    {
        int max, cou = 1, sum=0;
        max = Convert.ToInt32(Console.ReadLine());
        while (cou <= max) 
        {
            sum = sum + cou;
            cou++;

        }
        Console.WriteLine("Total : " + sum);
    } */


    /*public void loopfn(int max)
     {
         int sum = 0;
      
        for(int cou = 1; cou<= max; cou++)
         {
             sum+= Convert.ToInt32( Math.Pow(cou, 3));


         } return sum;
       
     }


    public void  foreachfn(string s1)
        {
        
          foreach(char s in s1)
        {
        Console.WriteLine(s);
        }
        }*/


    public void arrdis()
    {
      
        Array nums = new int[ , ] { { 10, 20, 40, 50, 60}, {60, 30, 39, 78,00 } };

        foreach (int n in nums)      
        {
            Console.WriteLine(n);

        }
        Array.Sort(nums);
    }
}
