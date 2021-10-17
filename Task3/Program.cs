using System;

namespace Task3
{
    interface IAnimal
    {
        void Voice();
    }

    class Cat : IAnimal
    {
        public string Name;
        public Cat(string Name)
        {
            this.Name = Name;
        }
        public void Voice()
        {
            Console.WriteLine("Мяу, блин");
        }
    }
    class Dog : IAnimal
    {
        public void Voice()
        {
            Console.WriteLine("Гав, блин");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            IAnimal Zver = new Cat("барсик");
            Zver.Voice();
            Zver = new Dog();
            Zver.Voice();
        }
    }
}
