using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        //İnterfaceler , soyutlama

        static void Main(string[] args)
        {
            ICrediManager ihtiyacKrediManager = new İhtiyacKrediManager();
            

            ICrediManager tasitKrediManager = new TasitKrediManager();
          

           ICrediManager konutKrediManager = new KonutKrediManager();


            ILoggerService databaseLoggerService = new DataBaseLoggerService();

            ILoggerService fileLoggerService = new FileLoggerService();




            BasvuruManager basvuruManager = new BasvuruManager();

            basvuruManager.BasvuruYap(ihtiyacKrediManager, fileLoggerService);

            List<ICrediManager> crediler = new List<ICrediManager>() { ihtiyacKrediManager, tasitKrediManager};
            //basvuruManager.KrediOnBilgilendirmesiYap(crediler);
        }
    }
}
