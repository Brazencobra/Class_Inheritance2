using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Inheritance2.Models
{
    internal class Group
    {
        public string GroupName;
        public Student[] Students = new Student[0]; 

        public Group(string groupname)
        {
            GroupName = groupname;
        }

        public void AddStudent(Student student)
        {
            Student[] students = new Student[Students.Length + 1];
            for (int i = 0; i < Students.Length; i++)
            {
                students[i] = Students[i];
            }
            students[students.Length-1] = student;
            Students = students;
        }
        public void GetAll()
        {
            foreach (Student item in Students)
            {
                Console.WriteLine($"{item.Name} {item.Surname}");
            }
        }
        public void GetOnlineStudents()
        {
            int count = 0;
            foreach (Student item in Students)
            {
                if (item.IsOnline == true)
                {
                    count++;
                }
            }

            if (count > 0)
            {
                foreach (Student item in Students)
                {
                    if (item.IsOnline == true)
                    {
                        Console.WriteLine($"{item.Name} {item.Surname}");
                    }
                }
            }
            else
            {
                Console.WriteLine("Online oxuyan telebe yoxdur");
            }
        }

        public void GetOfflineStudents()
        {
            int count = 0;
            foreach (Student item in Students)
            {
                if (item.IsOnline == false)
                {
                    count++;
                }
            }

            if (count > 0)
            {
                foreach (Student item in Students)
                {
                    if (item.IsOnline == false)
                    {
                        Console.WriteLine($"{item.Name} {item.Surname}");
                    }
                }
            }
            else
            {
                Console.WriteLine("Offline oxuyan telebe yoxdur");
            }
        }
    }
}
