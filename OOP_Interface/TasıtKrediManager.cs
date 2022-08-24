using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Interface
{
    class TasıtKrediManager : IKrediManager
    {
        public void Hesapla()
        {
            Console.WriteLine("Taşıt Kredisi Ödeme Planı HAzırlandı.");
        }

        public void Yazdir()
        {
            throw new NotImplementedException();
        }
    }
}
