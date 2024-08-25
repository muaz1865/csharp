// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
class Program
{
    static void Main()
    {
        var manager = new PersonManager();

        // Create
        var person1 = manager.Create("Alice", 30);
        var person2 = manager.Create("Bob", 25);

        // Read
        Console.WriteLine("All people:");
        foreach (var person in manager.ReadAll())
        {
            Console.WriteLine($"Id: {person.Id}, Name: {person.Name}, Age: {person.Age}");
        }

        // Update
        manager.Update(person1.Id, "Alicia", 31);
        var updatedPerson = manager.Read(person1.Id);
        Console.WriteLine($"\nUpdated person: Id: {updatedPerson.Id}, Name: {updatedPerson.Name}, Age: {updatedPerson.Age}");

        // Delete grtgfrgfgf
        manager.Delete(person2.Id);

        // Read all after deletion
        Console.WriteLine("\nAll people after deletion:");
        foreach (var person in manager.ReadAll())
        {
            Console.WriteLine($"Id: {person.Id}, Name: {person.Name}, Age: {person.Age}");
        }
    }
}
