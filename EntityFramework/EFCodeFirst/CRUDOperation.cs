 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirst
{
    internal class CRUDOperation
    {
        public void InsertRecordsInCourseEntity()
        {
            using (var context = new CollegeContext()) 
            {
                var cour = new Course()
                {
                    CourseID = 101,
                    Name = "ECE"
                };
                context.Courses.Add(cour);
                context.SaveChanges();
            }

        }

        public void InsertRecordsInStudentEntity()
        {
            using (var context = new CollegeContext())
            {
                var stud = new Student()
                {
                    StudentID = 1000,
                    Name = "Sundar",
                    Age = 22
                };
                context.Students.Add(stud);
                context.SaveChanges();
            }
        }
            public void UpdateRecordsInStudentEntity()
            {

                using(var context = new CollegeContext())
            {
                var st = context.Students.First<Student>(s =>(s.StudentID == 1000));
                //context.Students.First<Student>().Age=24;
                context.SaveChanges();
            }
             }
        public void DeleteRecordsInStudentEntity()
        {

            using (var context = new CollegeContext())
            {
                var de = context.Students.First<Student>();
                context.Remove(de);
                context.SaveChanges();
            }
        }


        public void ReadDataFromStudentsEntity(string stname)
        {
            using (var context = new CollegeContext())
            {
                var st = context.Students.Where(s => s.Name == stname);


                foreach(var s in st)
                Console.WriteLine(s.Name);

                
            }
        }

    }
}
