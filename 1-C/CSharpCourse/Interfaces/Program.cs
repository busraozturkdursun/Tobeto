namespace Interfaces;

class Program
{
    static void Main(string[] args)
    {

    }
}

interface IPerson
{
    int Id { get; set; }
    int FirstName { get; set; }
    int LastName { get; set; }


}

class Customer : IPerson
{
    //1. kullanım
    public int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public int FirstName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public int LastName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    //2. kullanım
    public string Address { get; set; }
}

class Student : IPerson
{
    public int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public int FirstName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public int LastName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    public string Departmant { get; set; }

}