using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using static System.Console;

namespace EasySave
{
    class Program
    {
        static void Main(string[] args)
        {
            ViewEN myViewEN = new ViewEN();
            ViewFR myViewFR = new ViewFR();
            myViewEN.Start();
        }
    }
}
