using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace MHG.SwitchCase
{
    class Person 
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }

    class Employee : Person 
    {
        public Employee(string name, int age) : base(name, age)
        {
            
        }
    }

    class Boss : Person 
    {
        public Boss(string name, int age) : base(name, age)
        {
            
        }
    }

    class Secretary : Person 
    {
        public Secretary(string name, int age) : base(name, age)
        {
            
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            #region Sample 1
            int number = 1;
            if(number == 1) {
                Console.WriteLine("Durum 1");
            } else if (number == 2) {
                Console.WriteLine("Durum 2");
            } else {
                Console.WriteLine("Varsayılan durum");
            }
            #endregion

            #region Sample 2
            int number = 1;
            switch (number)
            {
                case 1:
                    Console.WriteLine("Durum 1");
                    break;
                case 2:
                    Console.WriteLine("Durum 2");
                    break;
                default:
                    Console.WriteLine("Varsayılan durum");
                    break;
            }
            #endregion

            #region Sample 3
            switch(DateTime.Now.DayOfWeek) {
                case DayOfWeek.Monday:
                case DayOfWeek.Tuesday:
                case DayOfWeek.Wednesday:
                case DayOfWeek.Thursday:
                case DayOfWeek.Friday:
                    Console.WriteLine("Haftaiçindeyiz çalışmaya devam...");
                    break;
                case DayOfWeek.Saturday:
                case DayOfWeek.Sunday:
                    Console.WriteLine("Dinlen şimdi pazartesi iş bizi bekler...");
                    break;
            }
            #endregion

            #region Sample 4
            switch(DateTime.Now.DayOfWeek) {
                case DayOfWeek.Saturday:
                case DayOfWeek.Sunday:
                    Console.WriteLine("Dinlen şimdi pazartesi iş bizi bekler...");
                    break;
                default:
                    Console.WriteLine("Haftaiçindeyiz çalışmaya devam...");
                    break;
            }
            #endregion

            #region Sample 5
            int[] values = { 2, 4, 6, 8, 10 };
            ShowCollectionInformation(values);

            var names = new List<string>();
            names.AddRange( new string[] { "Murat", "Sakine", "Ramazan", "Hatice" } );
            ShowCollectionInformation(names);

            List<int> numbers = null;
            ShowCollectionInformation(numbers);
            #endregion

            #region Sample 4
            var boss1 = new Boss("Murat ÖNER", 28);
            var boss2 = new Boss("Sakine ÖNER", 23);
            var employee1 = new Employee("Tevfik Tok", 40);
            var employee2 = new Employee("Suna Kalın", 32);
            var secretary = new Secretary("Handan Altun", 22);
            var unknowPerson = new Person("Şevket Tur", 59);

            CheckPeople(boss1, employee1, secretary, employee2, boss2, unknowPerson);
            #endregion
        }

        private static void ShowCollectionInformation(object coll)
        {
            switch (coll)
            {
                case Array arr:
                Console.WriteLine($"{arr.Length} elemenanlı bir array.");
                break;
                case IEnumerable<int> ieInt:
                Console.WriteLine($"Ortalama: {ieInt.Average(s => s)}");
                break;   
                case IList list:
                Console.WriteLine($"{list.Count} eleman.");
                break;
                case IEnumerable ie:
                string result = "";
                foreach (var item in ie) 
                    result += "${e} ";
                Console.WriteLine(result);
                break;   
                case null:
                // null değeri için hiçbirşey yapılmayacak ve switch ifadesindeki değer null olsa dahi bu bloğa uğramayacak.
                break;
                default:
                Console.WriteLine($"Türü > {coll.GetType().Name}");
                break;   
            }
        }

        private static void CheckPeople(params Person[] persons)
        {
            var oldAge = 30;
            foreach (var person in persons)
            {
                switch (person)
                {
                    case Boss boss when boss.Age >= oldAge:
                        Console.WriteLine($"{boss.Name} adındaki yaşlı patron geldi.");
                        break;
                    case Boss boss when boss.Age < oldAge:
                        Console.WriteLine($"{boss.Name} adındaki genç patron geldi.");
                        break;   
                    case Employee employee when employee.Name.StartsWith("Tevfik"):
                        Console.WriteLine($"Adı tevfik ile başlayan {employee.Name} tam adı olan personel algılandı.");
                        break;
                    case Employee employee when employee.Name.StartsWith("Suna") || employee.Age > oldAge:
                        Console.WriteLine($"Adı suna ile başlayan ve {oldAge} yaşından büyük olan {employee.Name} tam adı olan personel algılandı.");
                        break;   
                    case Secretary secretary when secretary.Age < oldAge:
                        Console.WriteLine($"{oldAge} yaşın altında genç bir sekreter algınaldnı.");
                        break;
                    case Person persn:
                        Console.WriteLine($"{persn.Name} adında bilinmeyen bir kişi algılandı.");
                        break;
                }
            }
        }
    }
}
