// See https://aka.ms/new-console-template for more information

Add();
Add();
Add();
Add();
var result = Add2(20,30);
Console.WriteLine(result);


static void Add()
{
    Console.WriteLine("Added!");
}


static int Add2(int number1, int number2)
{
    var result = number1 + number2;
    return result;
}