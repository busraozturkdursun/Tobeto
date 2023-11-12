using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    class SepetManager
    {
        //name convention
        //syntax
        /*kapsulleme => Ekle metodunda kullanılan Urun classı özellikleri yenilendiginde/degistiginde (örn Urun classına +1 özellik eklendiğinde) Ekle metodunda bu özellik anında kullanılabilecektir cunkü Urun urun olarak instance edildiğinden yeni özelligi de barındırıyor olacaktır Ancak Ekle2'de ki kullanım icin yeni eklenen ozelligi kullanabilmek adına parantez icine tanımlama yapılması ve bu metodu kullanan tum alanlara da ekleme yapılması gerekecektir bu sekil kullanım dogru bir kullanım değldir.*/
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Tebrikler Sepete eklendi: " + urun.Adi);
        }

        public void Ekle2(string urunAdi, string aciklama, double fiyat,int stokAdedi)
        {
            Console.WriteLine("Tebrikler Sepete eklendi: " + urunAdi);
        }    
    }
}
