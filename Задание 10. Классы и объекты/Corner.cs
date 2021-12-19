using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_10.Классы_и_объекты
{
    class Corner
    {
        int grd, min, sec;
        double grddecimal, grdRad;

        public int Grd { get { return grd; } set { grd = value; } }
        //(ВЫСТАВИЛ ОГРАНИЧЕНИЯ, они так и НЕ СРАБОТАЛИ, БЕСТОЛКОВЫЙ МЕТОД или я ЕГО не понял, оставил его таким)
        //{
        //    get
        //    {
        //        return grd;
        //    }
        //    set
        //    {
        //        if(value <= 360)
        //        {
        //            grd = value;
        //        }
        //        else
        //        {
        //            Console.WriteLine("\nне корректный ввод"); 
        //        }
        //    }
        //}
        public int Min { get { return min; } set { min = value; } }

        public int Sec { get { return sec; } set { sec = value; } }


        public Corner()
        {
            while (true)
            {
                Console.Clear();

                try
                {
                    Console.WriteLine("\nвведите ГРАДУСЫ");
                    grd = int.Parse(Console.ReadLine());
                    Console.WriteLine("\nвведите МИНУТЫ");
                    min = int.Parse(Console.ReadLine());
                    Console.WriteLine("\nвведите СЕКУНДЫ");
                    sec = int.Parse(Console.ReadLine());
                    if (grd > 360 || grd < 0 || min > 60 || min < 0 || sec > 60 || sec < 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nне корректный ввод");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("\nповторите ввод");
                        Console.ReadKey();
                        continue;
                    }
                    else
                    {
                        GetInfo();

                    }
                }
                catch (Exception)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n не правильнный ввод!");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.ReadLine();
                    continue;
                }

            }


        }

        // метод выводит значение угла
        public void GetInfo()
        {
            Console.WriteLine($"\nнашЪ угол равен = {grd + "°"}{ min + "'"}{ sec + "\""}");
            Console.ReadLine();
        }

        //метод TogrdDecimal для перевода угла в десятичные
        public void TogrdDecimal()
        {
            
            grddecimal = grd + ((double)min / 60) + ((double)sec / 3600);
            Console.WriteLine("\nУгол в десятичных = {0:F3}", $"{grddecimal}" + "°"); 
        }

        //метод ToRadians для перевода угла в радианы

        public void ToRad()
        {
            grdRad = grddecimal * (Math.PI / 180);
            Console.WriteLine("\nУгол в радианах = {0:F3}", $"{grdRad}");
        }

        // конструктор для установки начальных значений       

        public Corner(int grd, int min, int sec)

        {
            Grd = grd;
            Min = min;
            Sec = sec;


        }
    }

}

