using System;
using System.Collections.Generic;

namespace OOP_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            //KonutKrediManager konutKrediManager = new KonutKrediManager();
            //konutKrediManager.Hesapla();
            //TasıtKrediManager tasıtKrediManager = new TasıtKrediManager();
            //tasıtKrediManager.Hesapla();
            //IhtiyacKrediManager ıhtiyacKrediManager = new IhtiyacKrediManager();
            //ıhtiyacKrediManager.Hesapla();



            // Demek ki neymiş: İnterface'ler de o interface'i implemente eden class'ın referans numarasını tutabiliyormuş 
            //IKrediManager konutKrediManager1 = new KonutKrediManager();
            //konutKrediManager1.Hesapla();
            //IKrediManager tasıtKrediManager1 = new TasıtKrediManager();
            //tasıtKrediManager1.Hesapla();
            //IKrediManager ıhtiyacKrediManager1 = new IhtiyacKrediManager();
            //ıhtiyacKrediManager1.Hesapla();

            //şimdi BaşvuruManager ekranı  yaptık.bu aşagıda gördüğün 3 satır kodu kullanıcının hangi krediye başvuracağını seçtiği menü giibi düşün. 
            IKrediManager konutKrediManager = new KonutKrediManager();
            IKrediManager tasıtKrediManager = new TasıtKrediManager();
            IKrediManager ıhtiyacKrediManager = new IhtiyacKrediManager();

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(tasıtKrediManager,new List<ILoggerService>{ new DatabaseLoggerService(),new FileLoggerService()}); // müşteri bunu şecti varsaydım. Dikkat et burda benden IKrediManager tipinde istedi . :)


            List<IKrediManager> krediManagers = new List<IKrediManager>() { konutKrediManager, tasıtKrediManager };
            basvuruManager.KrediOnBilgilendirmeYap(krediManagers);
            

        }
    }
}
