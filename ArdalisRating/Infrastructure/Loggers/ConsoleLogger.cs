using System;
using System.Collections.Generic;
using System.Text;

namespace ArdalisRating.Infrastructure.Loggers
{
    public class ConsoleLogger
    {
        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }
}
