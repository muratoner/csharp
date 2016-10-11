using System;

namespace MHG.Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            var murat = new Person("Murat ÖNER", 25, 7500);
            var sakine = new Person("Sakine Salmanlı", 22, 9000);

            var salary = sakine - murat;
            Console.WriteLine(salary);
            Console.WriteLine(sakine == murat);
            Console.WriteLine(sakine != murat);
            Console.ReadKey();
        }        
    }
}