using System;

class Program
{
    static void Main(string[] args)
    {
        
        Student student = new Student { Name = "jyo", StudentID = 43 };

       
        Person person = student;  
        person.Display();         

       
        Student downcastedStudent = (Student)person;  
        downcastedStudent.ShowID();  

        
        Student safeStudent = person as Student;
        if (safeStudent != null)
        {
            safeStudent.ShowID();  
        }
    }
}

