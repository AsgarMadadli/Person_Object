using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;
using System.Xml.Linq;

namespace ConsoleApp1
{
    public class Person
    {
        public Person(string name, string surname, int age, decimal height, int weight)
        {
            Name = name;
            SurName = surname;
            Age = age;
            Height = height;
            Weight = weight;
        }

        public string Name { get; set; }
        public string SurName { get; set; }
        public int Age { get; set; }
        public decimal Height { get; set; }
        public int Weight { get; set; }

        public override string ToString()
        {
            return $"Name{Name}, Surname {SurName}, Age: {Age}, Height: {Height}, Weight: {Weight}";
        }
    }





    public class Program
    {
        static void Main(string[] args)
        {
            Person user1 = new Person("Asger", "Mdadli", 15, 1.70m, 56);
            Console.WriteLine(user1.ToString());




        }
    }
}