using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class İhtiyacKrediManager : ICrediManager
    {
        public void Ekle()
        {
            throw new NotImplementedException();
        }

        public void Hesapla()
        {
            Console.WriteLine("İHTİYAÇ KREDİSİ ÖDEME PLANI HESAPLANDI");
        }
    }
}

//interface leri birbirinin alternetifi olan ama kod içerikleri farklı 
//olan durumlar için kullanırız.
//log -lama sistemde olan hareketleri nasıl dökeriz? Dosya da veri tabanında ya da sms ile tutabiliriz.
