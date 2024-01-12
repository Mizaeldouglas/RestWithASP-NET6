using System;
using RestWithASP_NET6_UDEMY.Models;

namespace RestWithASP_NET6_UDEMY.Services.Implementations;

public class PersonServiceImplementation : IPersonService
{
    private volatile int count;

    public Person Create(Person person)
    {
        return person;
    }

    public void Delete(long id)
    {
       
    }

    public List<Person> FindAll()
    {

        List<Person> persons = new List<Person>();
        

        for (int i = 0; i < 8; i++)
        {
            var person = new Person();
            person = MockPerson(i);
            persons.Add(person);
        }
        return persons;
    }

    
    public Person FindById(long id)
    {
        return new Person
        {
            Id = IncrenentAndGet(),
            FistName = "Mizael",
            LastName = "Douglas",
            Address = "Limeira - São Paulo - Brasil",
            Gender = "Male"
        };
    }

    public Person Update(Person person)
    {
        return person;
    }

    private Person MockPerson(int i)
    {
        int maleOrFemale = i;

        return new Person
        {
            Id = IncrenentAndGet(),
            FistName = "Person Name" + i,
            LastName = "Person LastName" + i,
            Address = "Some Address" + i,
            Gender = (maleOrFemale % 2 == 0) ? "Male" : "Female"
    };
    }

    private long IncrenentAndGet()
    {
        return Interlocked.Increment(ref count);
    }
}

