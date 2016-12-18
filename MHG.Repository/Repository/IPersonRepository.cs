namespace MHG.Repository.Repository
{
    interface IPersonRepository
    {
        Model.Person Get(int id);
        Model.Person Create(Model.Person person);
        bool Update(Model.Person person);
        bool Delete(Model.Person person);
    }
}
