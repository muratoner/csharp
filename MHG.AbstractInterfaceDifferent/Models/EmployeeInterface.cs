namespace MHG.AbstractInterfaceDifferent.Models
{
    /// <summary>
    /// IPerson arayüzü içerisinde tanımlı olan 3 üyenin tümünü arayüz olduğundan implement etmek zorunda kaldım ve metod gövdelerini alttaki gibi doldurdum.
    /// </summary>
    class EmployeeInterface : IPerson
    {
        public string Name { get; set; }

        public string GetName()
            => Name;

        public string GetNameWithDesciption()
            => $"Bu Kullanıcının Adı: {Name}";
    }
}
