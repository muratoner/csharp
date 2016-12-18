using System;
using System.Collections.Generic;
using System.Linq;
using MHG.Repository.Model;

namespace MHG.Repository.Repository
{
    class PersonRepository : IPersonRepository
    {
        readonly IList<Person> _list = new List<Person>(); 

        public Person Get(int id)
        {
            return _list.FirstOrDefault(T => T.ID == id);
        }

        public Person Create(Person person)
        {
            var lastid = _list.Count == 0 ? 1 : _list.LastOrDefault().ID + 1;
            var res = Get(lastid);
            if(res != null)
                throw new InvalidOperationException($"{person.ID} özelliğine girmiş olduğunuz {person.ID} değerİ ile eşleşen kayıt bulunmuştur.");
            person.ID = lastid;
            _list.Add(person);
            return person;
        }

        public bool Update(Person person)
        {
            var res = _list.IndexOf(person);
            if (res == -1)
                throw new KeyNotFoundException("Kayıt bulunamadı");
            _list[res] = person;
            return true;
        }

        public bool Delete(Person person)
        {
            if(person == null)
                throw new NullReferenceException($"{nameof(person)} değişkeni boş geçilemez.");
            var res = Get(person.ID);
            if(res == null)
                throw new NullReferenceException($"{person.ID} değeri ile eşleşen Person kaydı bulunamadı.");
            _list.RemoveAt(_list.IndexOf(person));
            return true;
        }
    }
}
