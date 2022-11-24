using System;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using System.Text.Json.Serialization;

namespace Project_test
{
    public class Json
    {
        public String name {get; set; }
        public String FileSource { get; set; }
        public String FileTarget { get; set; }
        public String destPath { get; set; }
        public float FileSize { get; set; }
        public long FileTransferTime { get; set; }
        public String time { get; set; }


    }
    class Modeleview
    {
    }
    class Program
    {
        void test (string json,string name)
        { 
        string path =name;
            if (!File.Exists(path))
            {
                try
                {
                    // Create the file, or overwrite if the file exists.
                    using (FileStream fs = File.Create(path))
                    {
                        byte[] info = new UTF8Encoding(true).GetBytes(json);
                        // Add some information to the file.
                        fs.Write(info, 0, info.Length);
                    }

                    // Open the stream and read it back.
                    using (StreamReader sr = File.OpenText(path))
                    {
                        string s = "";
                        while ((s = sr.ReadLine()) != null)
                        {
                            Console.WriteLine(s);
                        }
                    }
                }

                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }
            else
            {
                File.Delete(path);
                try
                {
                    // Create the file, or overwrite if the file exists.
                    using (FileStream fs = File.Create(path))
                    {
                        byte[] info = new UTF8Encoding(true).GetBytes(json);
                        // Add some information to the file.
                        fs.Write(info, 0, info.Length);
                    }

                    // Open the stream and read it back.
                    using (StreamReader sr = File.OpenText(path))
                    {
                        string s = "";
                        while ((s = sr.ReadLine()) != null)
                        {
                            Console.WriteLine(s);
                        }
                    }
                }

                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
                try
                {
                    // Create the file, or overwrite if the file exists.
                    using (FileStream fs = File.Create(path))
                    {
                        byte[] info = new UTF8Encoding(true).GetBytes(json);
                        // Add some information to the file.
                        fs.Write(info, 0, info.Length);
                    }

                    // Open the stream and read it back.
                    using (StreamReader sr = File.OpenText(path))
                    {
                        string s = "";
                        while ((s = sr.ReadLine()) != null)
                        {
                            Console.WriteLine(s);
                        }
                    }
                }

                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }

            }
        }
        static void Main(string[] args)
        {
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
            var json = new Json() {
                name = "test.txt",
                FileSource = pathes,
                FileTarget = path,
                destPath = "",
                FileSize = size,
                FileTransferTime = sw.ElapsedMilliseconds,
                time = DateTime.Now.ToString("dd/M/y HH:mm:ss")
            };
            string jsonString = JsonSerializer.Serialize(json);
            Program test = new Program();
            test.test(jsonString,paths);

            Console.WriteLine("test");

            
            
        }
    }
}
