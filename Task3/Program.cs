using System;

namespace Task3
{
    interface Animal
    {
        void Voice();
    }

    class Cat : Animal
    {
        public string Name;
        public Cat(string Name)
        {
            this.Name = Name;
        }
        public void Voice()
        {
            Console.WriteLine("Мяу блин");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var Kotik = new Cat("барсик");
            Kotik.Voice();
        }
    }
}
