using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Interface
{
    class DatabaseLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("veritabanına loglandı.");
        }
    }
}
