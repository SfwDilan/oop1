using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Interface
{
    class KonutKrediManager : IKrediManager
    {
        public void Hesapla()
        {
            Console.WriteLine("Konut Kredisi Ödeme Planı HAzırlandı.");
        }

        public void Yazdir()
        {
            throw new NotImplementedException();
        }
    }
}
