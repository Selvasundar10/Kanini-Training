using EFCodeFirst;

class Program
{
   public static void Main(string[] args)
    {
        CRUDOperation crud = new CRUDOperation();
        /* crud.InsertRecordsInStudentEntity();
         crud.InsertRecordsInCourseEntity();

         crud.UpdateRecordsInStudentEntity();
         crud.DeleteRecordsInStudentEntity();*/
        crud.ReadDataFromStudentsEntity("Sundar");
    }
}