using Class_Inheritance2.Models;

namespace Class_Inheritance2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Person person1 = new Person("Elxan", "Mammadli", 20);
            //Person person2 = new Person("Ilham", "Mikayilov", 21);
            //Person person3 = new Person("Murad", "Babayev", 26);
            //Person person4 = new Person("Ali", "Farzaliyev", 32);
            //Person person5 = new Person("Zerife", "Memmedova", 18);


            Student student1 = new Student("Elxan", "Mammadli", 20,false);
            Student student2 = new Student("Ilham", "Mikayilov", 21, true);
            Student student3 = new Student("Murad", "Babayev", 26, false);
            Student student4 = new Student("Ali", "Farzaliyev", 32, false);
            Student student5 = new Student("Zerife", "Memmedova", 18,true);
            Student student6 = new Student("Nihad", "Rehimli", 24,false);

            Group group1 = new Group("AB101");
            Group group2 = new Group("AP104");

            group1.AddStudent(student1);
            group1.AddStudent(student2);
            group1.AddStudent(student3);
            //group1.GetAll();
            group2.AddStudent(student4);
            group2.AddStudent(student5);
            group2.AddStudent(student6);
            //group2.GetAll();
            group2.GetOfflineStudents();
            Console.WriteLine( " - - - - - - - - - - - -");
            group2.GetOnlineStudents();


        }
    }
}