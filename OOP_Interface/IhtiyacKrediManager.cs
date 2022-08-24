using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Interface
{
    class IhtiyacKrediManager : IKrediManager
    {
        public void Hesapla()
        {
            Console.WriteLine("İhtiyaç Kredisi Ödeme Planı HAzırlandı.");
        }

        public void Yazdir()
        {
            throw new NotImplementedException();
        }
    }
}
