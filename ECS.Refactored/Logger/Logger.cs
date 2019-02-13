using System;
using System.Collections.Generic;
using System.Text;

namespace ECS.Refactored.Logger
{
    public class Logger : ILogger
    {
        public string input { get; set; }
        public void WriteLogLine(string text)
        {
            Console.WriteLine(text);
        }
    }
}
