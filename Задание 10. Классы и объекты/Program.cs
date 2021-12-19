using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Задание_10.Классы_и_объекты
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Corner Ccorner = new Corner();
            Ccorner.GetInfo();
            Ccorner.ToRad();
            Ccorner.TogrdDecimal();
            Console.ReadKey();

        }

       
    }

}
