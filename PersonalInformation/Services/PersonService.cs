using PersonalInformation.Models;

namespace PersonalInformation.Services
{
    public class PersonService
    {
        private readonly List<Person>? _persons;
        public PersonService()
        {
            _persons = new List<Person>();
        }
        public Person? Get()
        {
            var employee = _persons.FirstOrDefault();

            if (employee == null)
                return null;

            return employee;
        }

        public bool Create(Person person)
        {
            _persons.Add(person);
            return true;
        }
    }
}
