namespace Interfaces;

class Program
{
    static void Main(string[] args)
    {
        //InterfacesIntro
        /*  PersonManager manager = new PersonManager();
          manager.Add(new Customer { Id = 1, FirstName = "Erdinç", LastName = "Dursun", Address = "İstanbul" });

          Student student = new Student
          {
              Id = 1,
              FirstName = "Büşra",
              LastName= "Öztürk",
              Departmant= "Computer Scieneces"
          };

          manager.Add(student);
          manager.Add(student);
        */
        // IPerson person = new Customer();

        //Demo
        //CustomerManager customerManager = new CustomerManager();
        //customerManager.Add(new SqlServerCustomerDal());

        ICustomerDal[] customerDals = new ICustomerDal[3];
        {
            new SqlServerCustomerDal();
            new OracleCustomerDal();
            new MySqlCustomerDal();
        };
        foreach (var customerdal in customerDals)
        {
            customerdal.Add();
        }

        Console.ReadLine();
}

interface IPerson
{
    int Id { get; set; }
    string FirstName { get; set; }
    string LastName { get; set; }
}

class Customer : IPerson
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Address { get; set; }
}

class Student : IPerson
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public string Departmant { get; set; }

}

    class Worker : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Departmant { get; set; }

    }

    class PersonManager
{
    public void Add(IPerson person)
    {
        Console.WriteLine(person.FirstName);
    }
}
}