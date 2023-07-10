using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    internal class ExamplesForClassification
    {
        public void example()
        {
            List<string> courses = new List<string>();
            courses.Add("c++ tutorials");
            courses.Add("c tutorials");
            courses.Add("c# tutorial");
            courses.Add("python tutorials");
            courses.Add("java tutorials");

            /* var tutorialcourses = from c in courses
                                   where c.Contains("tutorials")
                                   select c;*/
            var tutorialcourses = courses.Where(c => c.Contains("tutorials"));

            foreach (var tut in tutorialcourses)
            {
                Console.WriteLine(tut);
            }
        }
        public void Student()
        {


            IList<Student> studentList = new List<Student>() {
                new Student() { StudentId = 1, StudentName = "AAA",StudentPhone = 9898, Age = 13} ,
                new Student() { StudentId = 2, StudentName = "BBB", StudentPhone = 7978, Age = 21 } ,
                new Student() { StudentId = 3, StudentName = "CCC", StudentPhone = 98498, Age = 18 } ,
                new Student() { StudentId = 4, StudentName = "DDD" , StudentPhone = 98978, Age = 20} ,
                new Student() { StudentId = 5, StudentName = "EEE" , StudentPhone = 98988, Age = 15 }
            };
            var filterResult = from s in studentList where s.Age > 12 && s.Age < 20 select s;
            foreach (var std in filterResult)
            {
                Console.WriteLine(std.StudentPhone + " " + std.StudentId);
            }
        }
        public void FilteringType()
        {
            IList elements = new ArrayList();
            elements.Add(1);
            elements.Add("Two");
            elements.Add(3);
            elements.Add("Four");

            var strings = from e in elements.OfType<string>() select e;
            var numbers = from e in elements.OfType<Int32>() select e;

            foreach (string str in strings)
                Console.WriteLine("String" + " " + str);

            foreach (Int32 number in numbers)
                Console.WriteLine("String" + " " + number);

        }

        public void SortingOrderBy()
        {
            IList<Student> studentList = new List<Student>() {
                new Student() { StudentId = 1, StudentName = "ZZZ",StudentPhone = 9898, Age = 13} ,
                new Student() { StudentId = 2, StudentName = "YYY", StudentPhone = 7978, Age = 21 } ,
                new Student() { StudentId = 3, StudentName = "XXX", StudentPhone = 98498, Age = 18 } ,
                new Student() { StudentId = 4, StudentName = "WWW" , StudentPhone = 98978, Age = 20} ,
                new Student() { StudentId = 5, StudentName = "VVV" , StudentPhone = 98988, Age = 15 }
            };

            var result = from  Student in studentList orderby Student.StudentName  select Student;

            foreach (var std in result)
                Console.WriteLine(std.StudentName);


            var res = studentList.OrderByDescending(s => s.StudentName).ThenBy(s => s.Age);
            foreach (var std in res)
                Console.WriteLine(std.StudentName + " " + std.Age);

        }

        public void GroupBy()
        {
            IList<Student> studentList = new List<Student>() {
                new Student() { StudentId = 1, StudentName = "ZZZ",StudentPhone = 9898, Age = 13} ,
                new Student() { StudentId = 2, StudentName = "YYY", StudentPhone = 7978, Age = 21 } ,
                new Student() { StudentId = 3, StudentName = "XXX", StudentPhone = 98498, Age = 18 } ,
                new Student() { StudentId = 4, StudentName = "WWW" , StudentPhone = 98978, Age = 20} ,
                new Student() { StudentId = 5, StudentName = "VVV" , StudentPhone = 98988, Age = 15 }
            };
            var result = from s in studentList group s by s.StudentName;
            foreach (var s in result)
            {
                Console.WriteLine(s.Key);
                foreach (var x in s)
                    Console.WriteLine(x.StudentId + " " + x.Age);
            }
        }


        public void LookUp()
        {
            IList<Student> studentList = new List<Student>() {
                new Student() { StudentId = 1, StudentName = "ZZZ",StudentPhone = 9898, Age = 13} ,
                new Student() { StudentId = 2, StudentName = "YYY", StudentPhone = 7978, Age = 21 } ,
                new Student() { StudentId = 3, StudentName = "XXX", StudentPhone = 98498, Age = 18 } ,
                new Student() { StudentId = 4, StudentName = "WWW" , StudentPhone = 98978, Age = 20} ,
                new Student() { StudentId = 5, StudentName = "VVV" , StudentPhone = 98988, Age = 15 }
            };
            var result =studentList.ToLookup(s => s.StudentName);
            foreach (var s in result)
            {
                Console.WriteLine(s.Key);
                foreach (var x in s)
                    Console.WriteLine(x.StudentId + " " + x.Age);
            }
        }


    }

}

