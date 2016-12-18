using System;
using System.Collections.Generic;
using System.Linq;

namespace MHG.Lazy {
    class LazyTest {
        public LazyTest()
        {
            //Generic Lazy sınıfından Person tipiyle bir örnek alıyoruz.
            Lazy<Person> res = new Lazy<Person>();

            //Sınıfın oluşup oluşmadığı kontrol ediliyor
            Console.WriteLine("Oluştumu: " + res.IsValueCreated);

            //Value özelliği ile Person sınıfımızdaki Skill adlı propert'iye erişiyoruz 
            //ve Person sınıfının oluşturulması tetikleniyor.
            Console.WriteLine(res.Value.Skill.Count());

            //Sınıfın oluşup oluşmadığı kontrol ediliyor
            Console.WriteLine("Oluştumu: " + res.IsValueCreated);

            //Tekrar özelliğe erişiliyor ama bu defa constructor 
            //tetiklenmiyor çünkü daha önce örneği alındı Person nesnesinin
            Console.WriteLine(res.Value.Skill.Count());

            Console.ReadLine();
        }
    }

    class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public IEnumerable<string> Skill { get; set; }

        public Person()
        {
            Console.WriteLine("Person consturtor'i çalıştı.");
            Skill = new List<string> {"C#", ".NET", "Xamarin"};
        }
    }
}
