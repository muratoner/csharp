using System;
using MHG.AbstractInterfaceDifferent.Models;

namespace MHG.AbstractInterfaceDifferent
{
    class Program
    {
        static void Main(string[] args)
        {
            // Abstract class
            
            // new anahtar kelimesi ile oluşturamıyoruz -> Error CS0144  Cannot create an instance of the abstract class or interface 'Person'
            // var resAbstractError1 = new Person();

            // Interface'ler için new anahtar kelimesinin zaten kullanılmadığını biliyorduk. Üstteki CS0144 nolu hata fırlatılacaktır.
            // var resInterfaceError1 = new IPerson();

            // Person adlı abstract sınıfından türettiğimiz EmployeeAbstract adlı sınıfı artık new anahtar kelimesi ile nesne örneği alabiliyoruz.
            var resAbstract = new EmployeeAbstract {Name = "Murat ÖNER"};
            var nameAbstract = resAbstract.GetName();
            var nameWithDescriptionAbstract = resAbstract.GetNameWithDesciption();

            Console.WriteLine($"Name Abstract: {nameAbstract}");
            Console.WriteLine($"NameWithDescription Abstract: {nameWithDescriptionAbstract}");

            // IPerson adlı arayüzden türettiğimiz EmployeeInterface adlı sınıfı artık new anahtar kelimesi ile nesne örneği alabiliyoruz.
            var resInterface = new EmployeeInterface { Name = "Sakine ÖNER" };
            var nameInterface = resInterface.GetName();
            var nameWithDescriptionInterface = resInterface.GetNameWithDesciption();

            Console.WriteLine($"Name Interface: {nameInterface}");
            Console.WriteLine($"NameWithDescription Interface: {nameWithDescriptionInterface}");
        }
    }
}
