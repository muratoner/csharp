namespace MHG.Operators
{
    public class Person
    {
        public Person(string name, int age, decimal salary)
        {
            Name = name;
            Age = age;
            Salary = salary;
        }

        public string Name { get; set; }

        public int Age { get; set; }

        public decimal Salary { get; set; }

        /// <summary>
        /// Eşitlik kontrolü yapan metodu override edip sınıfımıza göre uyarladık ve Operatör metodlarının
        /// bazılarında kullandık bu metodu.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            return this.Name == (obj as Person).Name;
        }

        /// <summary>
        /// Eğer p parametresinde Name ile p2 parametresindeki Name eşit ise True dönecek.
        /// </summary>
        /// <param name="p"></param>
        /// <param name="p2"></param>
        /// <returns>Boolean değer dönecek.</returns>
        public static bool operator ==(Person p, Person p2)
        {
            return p.Equals(p2);
        }

        /// <summary>
        /// Eğer p parametresinde Name ile p2 parametresindeki Name eşit değil ise True dönecek.
        /// </summary>
        /// <param name="p"></param>
        /// <param name="p2"></param>
        /// <returns>Boolean değer dönecek.</returns>
        public static bool operator !=(Person p, Person p2)
        {
            return !p.Equals(p2);
        }

        /// <summary>
        /// p adlı parametrenin Salary(Maaş) değerinden p2 parametresindeki maaş değeri 
        /// çıkartılıp geriye decimal tipte sonuç dönecek.
        /// </summary>
        /// <param name="p"></param>
        /// <param name="p2"></param>
        /// <returns>Decimal tipte maaş sonucu geri dönecek.</returns>
        public static decimal operator -(Person p, Person p2)
        {
            return p.Salary - p2.Salary;
        }

        public static decimal operator +(Person p, Person p2)
        {
            return p.Salary + p2.Salary;
        }
    }
}