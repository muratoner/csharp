namespace MHG.AbstractInterfaceDifferent.Models
{
    /// <summary>
    /// interface new anahtar sözcüğü ile oluşturulamaz.
    ///
    /// Bir sınıf birden fazla interface’i kalıtım olarak alınabilir.
    ///
    /// Interface içerisinde boş metodlar tanımlanabilir
    /// 
    /// Interface içerisinde özellik ve metodlarda erişim belirleyiciler kullanılmaz fakat abstract sınıflarda kullanılabilir.
    /// </summary>
    interface IPerson
    {
        string Name { get; set; }

        string GetName();

        string GetNameWithDesciption();
    }
}
