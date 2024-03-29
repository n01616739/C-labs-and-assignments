using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms.StudentManagemntSystemAS3
{
    public class Student
    {
        public int StudentID { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public string Gender { get; set; }

        public string Class { get; set; }

        public int Grade { get; set; }

        //constructor
        
        public Student()
        {
        }
        public Student(int studentID, string firstName, string lastName, int age, string gender, string  classname, int grade)
        {
            StudentID = studentID;
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Gender = gender;
            Class = classname;
            Grade = grade;
        }

    }
}
