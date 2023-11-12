using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    class BasvuruManager
    {//method injection
        public void BasvuruYap(IKrediManager krediManager,List<ILoggerService> loggerServices)
        {
            //Basvuran bilgilerini degerlendirme
            krediManager.Hesapla();
           // loggerService.Log();

            foreach (var loggerService in loggerServices) 
            {
                loggerService.Log();
            }
        }
        //poliformizim
        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }
    }
}
