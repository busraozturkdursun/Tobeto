namespace Inheritance;

class Program
{
    static void Main(string[] args)
    {
        // Customer customer = new Customer();
        Person[] persons = new Person[3]
        {
            new Customer{FirtName = "Büşra"}, new Student{FirtName = "Erdinç"},
            new Person{FirtName = "Nazlı"}
        };

        foreach (var person in persons)
        {
            Console.WriteLine(person.FirtName);
        }
        Console.ReadLine();
    }
}

class Person
{
    public int Id { get; set; }
    public string FirtName { get; set; }
    public string LastName { get; set; }

}

class Customer :Person
{
    public string City { get; set; }
}

class Student : Person
{
    public string Department { get; set; }
}