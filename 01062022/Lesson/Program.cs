using System;

namespace Lesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user1 = new User();

            user1.SetPassword("Salam123");
            Console.WriteLine(user1.GetPassword());

            Human human1 = new Human();
            human1.SetAge(16);
            Console.WriteLine(human1.GetAge());

            human1.Age = 45;
            Console.WriteLine(human1.Age);

            Student student1 = new Student();
            student1.GroupNo = "AP";

            Console.WriteLine(student1.GroupNo);

            Car car1 = new Car();
            car1.Model = "Mercedes";
            car1.FuelCapacity = 80;

            Console.WriteLine(car1.FuelCapacity);

            Employee employee1 = new Employee();
            employee1.Age = 15;

            Console.WriteLine(employee1.Age);
        }
    }
}
