using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Interface
{
    interface IKrediManager
    {
        // İnterface'lere implementasyon diyoruz.
        void Hesapla();

        void Yazdir();
    }
    


    /*class KrediManager
    {
        public void Hesapla()
        {

        }
    }
    
    taşıt kredsi için hesapla kısmı farklı olur, ev kredisi için ve ihtiyaç kredisi için yine öyle. 
    İşte Bu durumlarda biz interface kullanırız. 
    class ismini sil yerine interface yaz.
    Hesapla() süslü paranteszleri yerine noktalı virgül yaz,public yazısını sil.
     */


    /* Bir interface şunu anlatır: Der ki:Eğer ki birisii bu interfasce'i kullanırsa içindeki operasyonları(Hesapla, Yazdır)yani metotları da kullanmak zorunda.
     
     */
}
