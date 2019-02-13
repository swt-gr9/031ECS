using System;
using System.Collections.Generic;
using System.Text;

namespace ECS.Refactored.Logger
{
    public interface ILogger
    {
        string input { get; set; }
        void WriteLogLine(string text);
    }
}
