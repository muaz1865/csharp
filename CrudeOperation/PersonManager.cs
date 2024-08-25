
using System;
using System.Collections.Generic;
using System.Linq;

public class PersonManager
{
    private List<Person> _people = new List<Person>();
    private int _nextId = 1;

    // Create
    public Person Create(string name, int age)
    {
        var person = new Person
        {
            Id = _nextId++,
            Name = name,
            Age = age
        };
        _people.Add(person);
        return person;
    }

    // Read
    public Person Read(int id)
    {
        return _people.FirstOrDefault(p => p.Id == id);
    }

    public IEnumerable<Person> ReadAll()
    {
        return _people;
    }

    // Update
    public bool Update(int id, string name, int age)
    {
        var person = _people.FirstOrDefault(p => p.Id == id);
        if (person != null)
        {
            person.Name = name;
            person.Age = age;
            return true;
        }
        return false;
    }

    // Delete
    public bool Delete(int id)
    {
        var person = _people.FirstOrDefault(p => p.Id == id);
        if (person != null)
        {
            _people.Remove(person);
            return true;
        }
        return false;
    }
}
