using System;
using System.Collections.Generic;
using System.Text;

namespace ECS.Refactored.Logger
{
    public class FakeLogger : ILogger
    {
        public string input { get; set; }
        public void WriteLogLine(string text)
        {
            input = text;
        }
    }
}
