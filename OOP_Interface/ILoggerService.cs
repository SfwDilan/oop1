using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Interface
{
    //Loglamayı dosyaya-veritabanına-sms yoluyla-email ile yapabilirsin.
    //Hepsinde imza aynı ama yaptığı iş farklı olduğu için interface yapıyoruz.
    interface ILoggerService
    {
        void Log();
    }
}
