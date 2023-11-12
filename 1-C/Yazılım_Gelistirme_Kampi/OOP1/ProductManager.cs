using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    class ProductManager
    {
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName + " eklendi");
        }

        //public void BiseyYap(int sayi)
        //{
        //    sayi = 99;
        //}

        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + " güncellendi.");
        }


        //topladıgımız sonucun degeri int seklinde baska bir yerde de kullanabilecegimiz sekilde kalıyor olacak
        //Program.cs'de cikan sonucu int'e atayıp yeniden bu sonucu kullandıgımız bir örnek mevcut
        public int Topla(int sayi1,int sayi2) 
        {
        return sayi1 + sayi2;
        }

        //sayilari toplar ve ekrana yazdırır
        //ortaya cıkan formülü baska bir yerde kullanmamız icin bu degeri bize vermez
        public void Topla2(int sayi1, int sayi2)
        {
            Console.WriteLine(sayi1+sayi2);
        }
    }
}
