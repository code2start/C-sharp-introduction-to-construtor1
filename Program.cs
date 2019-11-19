using System;

namespace inheritance1
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student() { ID = 1, Name = "Mohamed Ahmed", Age = 20 };
            Console.WriteLine(s1.ID + " " + s1.Name);
            Teacher t1 = new Teacher() { ID = 1, Name = "Mohamed Fathy", Age = 40, Department = "Arabic" };

            Console.WriteLine($" ID = {t1.ID}, Name = {t1.Name}");
        }
    }
}
