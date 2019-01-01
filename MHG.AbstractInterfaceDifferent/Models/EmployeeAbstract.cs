namespace MHG.AbstractInterfaceDifferent.Models
{
    /// <summary>
    /// Abstract class içerisinde toplamda 2 metod ve bir özellik olarak 3 üye var ama sadece ikisini
    /// abstract olarak işaretlediğimizden Person EmployeeAbstract adlı sınıfımıza kalıtım olarak geçtiğimizden zorunlu olarak 2 üyeyi implement olarak geçtik.
    /// </summary>
    class EmployeeAbstract : Person
    {
        public override string Name { get; set; }

        public override string GetNameWithDesciption()
            => $"Bu Kullanıcının Adı: {Name}";
    }
}
