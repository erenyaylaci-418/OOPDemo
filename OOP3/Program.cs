using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            BasvuruManager basvuruManager = new BasvuruManager();
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            //basvuruManager.BasvuruYap(ihtiyacKrediManager);

            IKrediManager tasitKrediManager = new TasitKrediManager();
            basvuruManager.BasvuruYap(tasitKrediManager,new DatabaseLoggerService());

            IKrediManager konutKrediManager = new KonutKrediManager();
            basvuruManager.BasvuruYap(konutKrediManager,new FileLoggerService());
            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager };

           // basvuruManager.KrediOnBilgilendirmesiYap(krediler);
             
            //interfaceleri birbirinin alternatifi olan kod içerikleri için kullanırız.

        }
    }
}
