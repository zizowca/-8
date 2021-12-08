using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Задание_8
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "D:/музыка/";
            if (Directory.Exists(path))
            {
                string[] dir = Directory.GetDirectories(path);
                foreach (string d in dir)
                {
                    Console.WriteLine(d);
                    string[] files = Directory.GetFiles(d);
                    foreach (string f in files)
                    {
                        Console.WriteLine(f);
                    }
                }
            }
            else
            {
                Console.WriteLine("Путь не найден");
            }
            Console.ReadKey();
        }
    }
}
