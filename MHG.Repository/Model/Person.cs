namespace MHG.Repository.Model
{
    class Person
    {
        public Person(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
    }
}
