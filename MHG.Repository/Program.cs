using MHG.Repository.Model;
using MHG.Repository.Repository;
using static System.Console;

namespace MHG.Repository
{
    class Program
    {
        static void Main(string[] args)
        {
            var personRepo = new PersonRepository();
            var person1 = personRepo.Create(new Person("Murat", "ÖNER"));
            var person2 = personRepo.Create(new Person("Sakine", "ÖNER"));
            personRepo.Delete(person1);
            var person3 = personRepo.Create(new Person("Zeynep", "ÖNER"));
            var person = personRepo.Get(3);
            WriteLine(person.ID);
            ReadLine();
        }
    }
}