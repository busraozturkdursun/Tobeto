
using System.Runtime.CompilerServices;
static void ForLoop()
{
    for (int i = 0; i <= 100; i += 2)
    {
        Console.WriteLine(i);
    }
    Console.WriteLine("Finished!");
}
//ForLoop();

static void WhileLoop()
{
    int number = 100;
    while (number >= 0)
    {
        Console.WriteLine(number);
        number--;
    }
    Console.WriteLine("Now number is {0}", number);
}
//WhileLoop();

static void DoWhileLoop()
{
    int number = 10;
    do
    {
        Console.WriteLine(number);
        number--;
    } while (number >= 11);
}
//DoWhileLoop()
static void ForEachLoop()
{
    string[] students = new string[3] { "Engin", "Demir", "Salih" };

    foreach (var stundent in students)
    {
        Console.WriteLine(stundent);
    }
}
//ForEachLoop();


if(IsPrimeNumber(6))
{
    Console.WriteLine("This is a prime number");
}
else
{
    Console.WriteLine("This is not a prime number");

}

static bool IsPrimeNumber(int number)
{
    bool result = true;
    for (int i = 2; i <= number - 1; i++)
    {
        if (number % i == 0)
        {
            result = false;
            i = number;
        }

    }
    return result;
}