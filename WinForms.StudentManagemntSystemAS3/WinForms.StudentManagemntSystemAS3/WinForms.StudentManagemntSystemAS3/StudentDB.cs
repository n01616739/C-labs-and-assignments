using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms.StudentManagemntSystemAS3
{
    internal class StudentDB
    {
        private static readonly string Path = @"C:\Users\siddh\OneDrive - Humber College\Documents\student.txt";

        public static List<Student> GetStudents()
        {
            List<Student> students = new List<Student>();

            using (StreamReader textIN = new StreamReader(new FileStream(Path, FileMode.OpenOrCreate, FileAccess.Read)))
            {
                string row;
                while ((row = textIN.ReadLine()) != null)
                {
                    string[] columns = row.Split(',');

                    if (columns.Length == 7)
                    {
                        Student student = new Student
                        {
                            StudentID = Convert.ToInt32(columns[0]),
                            FirstName = columns[1],
                            LastName = columns[2],
                            Age = Convert.ToInt32(columns[3]),
                            Gender = columns[4],
                            Class = columns[5],
                            Grade = Convert.ToInt32(columns[6])
                        };

                        students.Add(student);
                    }
                }
            }
            return students;
        }

        // Add a new student to the file

        public static void SaveStudents(List<Student> students)
        {
            using (StreamWriter textOUT = new StreamWriter(new FileStream(Path, FileMode.Create, FileAccess.Write)))
            {
                foreach (Student student in students)
                {
                    textOUT.Write(student.StudentID + ",");
                    textOUT.Write(student.FirstName + ",");
                    textOUT.Write(student.LastName + ",");
                    textOUT.Write(student.Age + ",");
                    textOUT.Write(student.Gender + ",");
                    textOUT.Write(student.Class + ",");
                    textOUT.WriteLine(student.Grade);
                }
            }
        }



        // Update an existing student in the file

        public static void UpdateStudent(Student updatedStudent)
        {
            List<Student> students = GetStudents();
            int index = students.FindIndex(s => s.StudentID == updatedStudent.StudentID);
            students[index] = updatedStudent;
            SaveStudents(students);
        }

        // Delete a student from the file

        public static void DeleteStudent(int index)
        {
            List<Student> students = GetStudents();
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this item?", "Delete Item", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
            {
                return;
            }
            students.RemoveAt(index);
            SaveStudents(students);

        }

    }
}
