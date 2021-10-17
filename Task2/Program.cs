using System;
using System.Collections.Generic;
using System.Linq;

namespace Task2
{
    class Depart
    {
        public string depart_name { get; set; }
        public string number { get; set; }
        public string head { get; set; }

        public Depart(string depart_name, string number, string head)
        {
            this.depart_name = depart_name;
            this.number = number;
            this.head = head;
        }

    }
    
    class Worker
    {
        public string surname { get; set; }
        public string firstname { get; set; }
        public string pathemic { get; set; }
        public int age { get; set; }
        public string department { get; set; }

        public Worker(string surname, string firstname, string pathemic, int age, string department)
        {
            this.surname = surname;
            this.firstname = firstname;
            this.pathemic = pathemic;
            this.age = age;
            this.department = department;
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            var frontend = new Depart("Фронт", "+79875271837", "Владислов Б.К.");
            var backend = new Depart("Бэк", "+79273655243", "Юрьев К.К.");
            var gaydew = new Depart("Игры", "+79042650807", "Деловой Ы.Ы.");

           
            var Danil = new Worker("Игнатьев", "Даниил", "Дмитривич", 4, frontend.depart_name);
            var Marat = new Worker("Сычев", "Марат", "Ингушетов", 27, backend.depart_name);
            var Artem = new Worker("Челиков", "Артем", "Владиславович", 13, frontend.depart_name);
            var Slava = new Worker("Рататататов", "Слава", "Мэрлоу", 18, gaydew.depart_name);
            var Valentin = new Worker("Джорджев", "Валентин", "Павлович", 36, frontend.depart_name);
            var Alisher = new Worker("Рамзесов", "Алишер", "Тагирович", 23, gaydew.depart_name);
            var Denis = new Worker("Дввачевский", "Денис", "Павлович", 25, backend.depart_name);
            var Artem2 = new Worker("Логвин", "Артем", "Артемович", 55, gaydew.depart_name);
            var Vladislav = new Worker("Персонов", "Владислав", "Сидрович", 16, backend.depart_name);

            var Workers = new List<Worker>() { Vladislav, Denis, Marat, Artem, Valentin, Danil, Alisher, Artem2, Slava };

            var sortWorkers = Workers.GroupBy(x => x.department).ToDictionary(x => x.Key, x => x.ToList());

            foreach (var i in sortWorkers)
            {
                Console.Write($"{i.Key}: ");
                foreach (var j in i.Value)
                    Console.Write($"{j.surname} ");
                Console.WriteLine();
            }
        }

        





    }
}
