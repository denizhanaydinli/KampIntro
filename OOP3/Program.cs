using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
          
            IKrediManager konutKrediManager = new KonutKrediManager();//interface implement edildiğiclasstan nesne oluşturabilir

            IKrediManager tasitKrediManager = new TasitKrediManager();
            ILoggerService fileLoggerService = new FileLoggerService();
            ILoggerService databaseLoggerService = new DatabaseLoggerService(); 
            BasvuruManager basvuruManager = new BasvuruManager();//Dependency Injection
            basvuruManager.BasvuruYap(ihtiyacKrediManager,new List<ILoggerService> {new DatabaseLoggerService(),new FileLoggerService() });

            List<IKrediManager> krediler = new List<IKrediManager>() { ihtiyacKrediManager,tasitKrediManager};

            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);
        
        }
    }
}
