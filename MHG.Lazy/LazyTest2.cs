using System;
using System.Collections.Generic;
using System.Linq;

namespace MHG.Lazy {
    class LazyTest2 {
        public LazyTest2()
        {
            //IEnumerable<Person> tipindeki Lazy tanımı yapıldı ve 
            //geri dönüş tipi IEnumerable<Person> olan metodumuz parametre olarak verildi.
            var res = new Lazy<IEnumerable<Person2>>(GetData);

            //IEnumerable<Person> nesnesinin 
            //daha önce oluşturulup oluşturulmadığı kontrol ediliyor.
            Console.WriteLine($"Oluşturuldumu: {res.IsValueCreated}");

            //IEnumerable listesine erişiyoruz.
            Console.WriteLine($"Kayıt Sayısı: {res.Value.Count()}");

            //IEnumerable<Person> nesnesinin 
            //daha önce oluşturulup oluşturulmadığı tekrar kontrol ediliyor.
            Console.WriteLine($"Oluşturuldumu: {res.IsValueCreated}");

            //IEnumerable listesine tekrar erişiyoruz.
            Console.WriteLine($"Kayıt Sayısı: {res.Value.Count()}");

            Console.ReadLine();
        }

        static IEnumerable<Person2> GetData()
        {
            Console.WriteLine("GetData metodu çalıştı.");
            return new[]
            {
                new Person2
                {
                    Name = "Murat",
                    Surname = "Öner"
                },
                new Person2
                {
                    Name = "XXXX",
                    Surname = "YYYYY"
                },
                new Person2
                {
                    Name = "AAAAA",
                    Surname = "BBBBBB"
                },
                new Person2
                {
                    Name = "CCCCC",
                    Surname = "DDDDD"
                }
            };
        }
    }

    class Person2
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public Person2()
        {
        }
    }
}
