using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        //Method injection
        public void BasvuruYap(ICrediManager crediManager, ILoggerService loggerService )
        {
            //Basvurun bilgilerini değerlendirme
            //

            
            crediManager.Hesapla();
            loggerService.Log();


        }

        public void KrediOnBilgilendirmesiYap(List <ICrediManager> crediler )
        {
            foreach (var credi in crediler)
            {
                credi.Hesapla();
            }
        }

    }
}
