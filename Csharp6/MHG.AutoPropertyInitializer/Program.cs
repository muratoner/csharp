using System;

namespace MHG.AutoPropertyInitializer
{
    class Program
    {


        static void Main(string[] args)
        {
            var person = new Person();
            Console.WriteLine(person.Age);
            Console.WriteLine(person.City);
            Console.ReadLine();
        }

        /// <summary>
        /// Auto Property Initilaizer tanımı ister get isterse get ve set tanımlı özelliklerde kullanılabiliyor.
        /// </summary>
        #region Auto Property Initializer
        class Person
        {
            public int Age { get; set; } = 99;
            public string City { get; } = "Kocaeli";
        }
        #endregion
    }
}
