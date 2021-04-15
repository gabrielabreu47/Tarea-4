using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class PersonServices
    {
        public Serializer serializer;
        public string Directory;
        public string FileName;

        public PersonServices()
        {
            serializer = new Serializer();
            Directory = "Persons";
            FileName = "persons.dat_" + UserRepository.Instancia.User.ToString();

        }
        public void Add(Person person)
        {
            PersonRepository.Instancia.Person.Add(person);
            serializer.Serialize(PersonRepository.Instancia.Person, Directory, FileName);
        }
        public void Edit(int id, Person person)
        {
            PersonRepository.Instancia.Person[id] = person;
            serializer.Serialize(PersonRepository.Instancia.Person, Directory, FileName);
        }
        public void Delete(int id)
        {
            PersonRepository.Instancia.Person.RemoveAt(id);
            serializer.Serialize(PersonRepository.Instancia.Person, Directory, FileName);
        }
        public List<Person> GetAll()
        {
            List<Person> people = (List<Person>)serializer.Deserialize(Directory, FileName);
            if(people != null)
            {
                PersonRepository.Instancia.Person = people;
            }
            return PersonRepository.Instancia.Person;

        }
        public Person Select(int id)
        {
            return PersonRepository.Instancia.Person[id];
        }
    }
}
