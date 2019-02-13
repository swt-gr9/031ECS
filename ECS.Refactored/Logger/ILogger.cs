using System;
using System.Collections.Generic;
using System.Text;

namespace ECS.Refactored.Logger
{
    public interface ILogger
    {
       void WriteLogLine(string text);
    }
}
