
using System.Reflection.Metadata;

//Intro();

string sentence = "My name is Engin Demiroğ";

var result = sentence.Length;
var result2 = sentence.Clone();

bool result3 = sentence.EndsWith("ğ");
bool result4 = sentence.StartsWith("My name");

var result5 = sentence.IndexOf("name");
var result6 = sentence.IndexOf(" ");
var result7 = sentence.LastIndexOf(" ");
var result8 = sentence.Insert(0, "Hello, ");    //0.indexten itibaren Hello ekle
var result9 = sentence.Substring(3, 4);          //3.karakterden itibaren 4 karakter al.
var result10 = sentence.ToLower();
var result11 = sentence.ToUpper();
var result12 = sentence.Replace(" ", "-");
var result13 = sentence.Remove(2,5);               //2.karakterden sonra 5 karakter sil.

Console.WriteLine(result13);
static void Intro()
{
    string city = "Ankara";
    //Console.WriteLine(city[0]);

    foreach (var item in city)
    {
        Console.WriteLine(item);
    }

    string city2 = "İstanbul";
    //string result = city + city2;
    //Console.WriteLine(result);

    Console.WriteLine(String.Format("{0} {1} ", city, city2));
    //3.bir değişken tanımlamadan string format ile yapabiliriz.
}

