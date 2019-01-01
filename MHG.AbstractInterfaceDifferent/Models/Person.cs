namespace MHG.AbstractInterfaceDifferent.Models
{
    /// <summary>
    /// Abstract sınıfa IPerson arayüzünü kalıtım olarak geçebildim ama tam tersi durum mümkün değil
    /// yani IPerson arayüzüne yine arayüz haricinde sınıfı kalıtım olarak geçemiyoruz.
    ///
    /// Interface içerisinde özellik ve metodlarda erişim belirleyiciler kullanılmaz fakat abstract sınıflarda kullanılabilir.
    /// </summary>
    public abstract class Person : IPerson // Buradaki arayüzü kalıtım olarak geçmemin bir esprisi yok dikkate almayınız sadece abstract class'a bir arayüzü kalıtım olarak geçebildiğimizi göstermek için ekledim :)
    {
        /// <summary>
        /// Bunu abstract olarak işaretlediğimiz için Person sınıfını kalıtım olarak
        /// alan sınıf bunu zorunlu olarak kendi içine implement edecektir.
        /// </summary>
        public abstract string Name { get; set; }

        /// <summary>
        /// Abstract class'larda hem boş metodlar tanımlanabilir hemde içi dolu metodlar tanımlabilir.
        /// </summary>
        /// <returns></returns>
        public string GetName()
        {
            return Name;
        }

        /// <summary>
        /// Abstract class'larda hem boş metodlar tanımlanabilir hemde içi dolu metodlar tanımlabilir.
        /// Abstract olarak işaretlendiğinden Person sınıfını kalıtım alan sınıf bu metodu implement etmek zorundadır.
        /// </summary>
        /// <returns></returns>
        public abstract string GetNameWithDesciption();
    }
}
