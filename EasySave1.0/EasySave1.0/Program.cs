using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Text.Json;
using System.Diagnostics;
using System.Threading;
using System.Text.Json.Serialization;
using static System.Console;

namespace EasySave
{
    class Program
    {
        static public void Main(string[] args)
        {
            ViewEN myViewEN = new ViewEN();
            myViewEN.Start();
        }
    }
}
