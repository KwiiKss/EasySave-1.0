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

            string pathes = @"C:\Users\Corso\Desktop\Dossier1\test.txt";
            string path = @"C:\Users\Corso\Desktop\Dossier2\test.txt";
            string paths = @"C:\Users\Corso\Desktop\Dossier2\LOGtest.txt";
            FileInfo fInfo = new FileInfo(pathes);
            float size = fInfo.Length;//taille en octets
            var sw = new Stopwatch();
            try
            {
                sw.Start();
                File.Move(pathes, path);
                Console.WriteLine("Moved");
                sw.Stop();
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex);
            }
            var json = new Json()
            {
                Name = "test.txt",
                FileSource = pathes,
                FileTarget = path,
                DestPath = "",
                FileSize = size,
                FileTransferTime = sw.ElapsedMilliseconds,
                Time = DateTime.Now.ToString("dd/M/y HH:mm:ss")
            };
            string jsonString = JsonSerializer.Serialize(json);
            Model myModel = new Model();
            myModel.Move(jsonString, paths);
        }
    }
}
