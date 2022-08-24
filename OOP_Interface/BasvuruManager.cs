using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Interface
{
    class BasvuruManager
    {
        

        //Burada başvuran kişiyle ilgili bilgiler vs. gibi pek çok kod yazılır.
        public void BasvuruYap(IKrediManager krediManager,List<ILoggerService> loggerServices) //Burda DEPENDENCY İNJECTİON öğreneceksin...(Method İnjection yaptık)
        {
            krediManager.Hesapla();
            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
            }
            
        }

        public void KrediOnBilgilendirmeYap(List<IKrediManager> krediManagers)
        {
            foreach (var kredi in krediManagers)
            {
                kredi.Hesapla();
            }
        }







        /*
         * 
         * public void BasvuruYap()
        {
             * aşağıdaki 2 satır kodu yazarsan çalışır ama dikkat.. Böyle yaparsan*
             * Tüm başvuruları konut kredisine bağımlı hale getirirsin.
             * Çok Önemli eğer burda yapmış olduğumuz şeyi anlarsan design patterni anlarsın.
             Bütün design pattern'lar bunun üzerine kurulur dikkat..

        KonutKrediManager konutKrediManager = new KonutKrediManager();
        konutKrediManager.Hesapla();

        } */




        /*
         *  O yüzden kodu böyle yazacağına ;
         *  
         * public void BasvuruYap()
        {
            
        KonutKrediManager konutKrediManager = new KonutKrediManager();
        konutKrediManager.Hesapla(); 
        }
        
         BÖYLE YAZARSIN 
        * public void BasvuruYap(IKrediManager ıkrediManager)
        {
            ıkreditManager.Hesapla();
        }

         */

    }
}
