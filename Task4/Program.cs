using System;

namespace Task4
{
    class Overload
    {
        public int Sum(int a, int b, int c)
        {
            return a + b + c;
        }
        public int Sum(int a, int b)
        {
            return a + b;
        }
    }

    class Person
    {
        public string Name, Family;
        
        public Person(string Name)
        {
            this.Name = Name;
        }
        public Person(string Name, string Family)
        {
            this.Name = Name;
            this.Family = Family;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var lalala = new Overload();
            Console.WriteLine(lalala.Sum(1, 2, 3));
            Console.WriteLine(lalala.Sum(2, 6));

            var pers1 = new Person("Ваня");
            var pers2 = new Person("Дэнчик", "челиков");
        }
    }
}
