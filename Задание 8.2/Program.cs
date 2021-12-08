using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Задание_8._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string path1 = "Test 8.2";
            if (!Directory.Exists(path1))
            {
                Directory.CreateDirectory(path1);
            }
            string path = "Test 8.2/Test 8.2.txt";
            if (!File.Exists(path))
            {
                File.Create(path).Close();
            }
            using (StreamWriter sw = new StreamWriter(path))
            {
                Random random = new Random();
                for (int n = 0; n < 10; n++)
                {
                    sw.WriteLine(random.Next(0, 100));
                }
            }
            string[] numb = File.ReadAllLines(path);
            int s = 0;
            for (int i = 0; i < 10; i++)
            {
                s += Convert.ToInt32(numb[i]);
            }
            Console.WriteLine("Сумма записанных в файл числе равна = {0}", s);
            Console.ReadKey();
        }
    }
}
