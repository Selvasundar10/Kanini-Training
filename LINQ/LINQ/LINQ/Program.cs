using LINQ;
using System;

//delegate bool EligibllityCheck(People person);

class Program

{
    public static void Main(string[] args)
    /*{
        People[] people =
        {
             new People() {Name = "Sundar", Age = 22},
             new People() {Name = "kalps", Age = 21},
             new People() {Name = "Vijay", Age = 20},
             new People() {Name = "Vsal", Age = 19},
             new People() {Name = "Satz", Age = 18},
        };*/
    /*
    People[] voters = new People[people.Length];

    int i = 0;
    foreach ( People person in people )
    {
        if(person.Age >=18)
        {
            voters[i] = person;
            Console.WriteLine(person.Name + " " +person.Age);
            i++;
        }
    }


    List<People> voters = VoterCheck.where(people, delegate (People person)
        {
            return person.Age >= 18;



        });
    foreach (People voter in voters) {
        Console.WriteLine(voter.Name);
    }*/


    /*People[] voters = people.Where(person => person.Age >=18).ToArray();
    foreach(People voter in voters)
    {
        Console.WriteLine(voter.Name);

    }
    */


    /*List<People> voters = people.Where(person => person.Age >= 18).ToList();
    foreach (People voter in voters)
    {
        Console.WriteLine(voter.Name);
    }*/

    /*var voters = from person in people where person.Age >= 18
        select person;
    foreach (People voter in voters)
    {
        Console.WriteLine(voter.Name);
    }*/

    {

    ExamplesForClassification examples = new ExamplesForClassification();
        examples.example();
       
        
        ExamplesForClassification stu = new ExamplesForClassification();
        stu.Student();


        ExamplesForClassification filter = new ExamplesForClassification();
        filter.FilteringType();


        ExamplesForClassification sorting = new ExamplesForClassification();
        sorting.SortingOrderBy();

        ExamplesForClassification grouping = new ExamplesForClassification();
        grouping.GroupBy();



        ExamplesForClassification lookup = new ExamplesForClassification();
        lookup.LookUp();
    }
}
