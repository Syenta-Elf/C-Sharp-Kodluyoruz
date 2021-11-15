using System;

namespace DateTime_ve_Math
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine(DateTime.Now);
            System.Console.WriteLine(DateTime.Now.Date);
            System.Console.WriteLine(DateTime.Now.Day);
            System.Console.WriteLine(DateTime.Now.Month);
            System.Console.WriteLine(DateTime.Now.Year);
            System.Console.WriteLine(DateTime.Now.Hour);
            System.Console.WriteLine(DateTime.Now.Minute);
            System.Console.WriteLine(DateTime.Now.Second);

            System.Console.WriteLine(DateTime.Now.DayOfWeek);        
            System.Console.WriteLine(DateTime.Now.DayOfYear);

            System.Console.WriteLine(DateTime.Now.ToLongDateString());        
            System.Console.WriteLine(DateTime.Now.ToShortDateString());        
            System.Console.WriteLine(DateTime.Now.ToLongTimeString());
            System.Console.WriteLine(DateTime.Now.ToShortTimeString());

            System.Console.WriteLine(DateTime.Now.AddDays(2));
            System.Console.WriteLine(DateTime.Now.AddHours(8));
            System.Console.WriteLine(DateTime.Now.AddSeconds(45));
            System.Console.WriteLine(DateTime.Now.AddMonths(3));
            System.Console.WriteLine(DateTime.Now.AddYears(10));
            System.Console.WriteLine(DateTime.Now.AddMilliseconds(10));

            //date Format
            System.Console.WriteLine(DateTime.Now.ToString("dd"));//15
            System.Console.WriteLine(DateTime.Now.ToString("ddd"));//Sat
            System.Console.WriteLine(DateTime.Now.ToString("dddd"));//Saturday

            System.Console.WriteLine(DateTime.Now.ToString("MM"));//04
            System.Console.WriteLine(DateTime.Now.ToString("MMM")); //Apr
            System.Console.WriteLine(DateTime.Now.ToString("MMMM")); //April

            System.Console.WriteLine(DateTime.Now.ToString("yy"));//21
            System.Console.WriteLine(DateTime.Now.ToString("yyyy"));//2021

            //Math

            System.Console.WriteLine("**** Math ****");
            System.Console.WriteLine(Math.Abs(-25));//mutlak

            System.Console.WriteLine(Math.Sin(10));//cos,sin,tan
            System.Console.WriteLine(Math.Cos(10));//cos,sin,tan
            System.Console.WriteLine(Math.Tan(10));//cos,sin,tan


            System.Console.WriteLine(Math.Ceiling(10.8));//Yukarı
            System.Console.WriteLine(Math.Round(10.3));//hangisine daha yakinsa
            System.Console.WriteLine(Math.Round(10.8));//hangisine daha yakinsa
            System.Console.WriteLine(Math.Floor(10.8));//Asagi
            
            System.Console.WriteLine(Math.Min(2,10));
            System.Console.WriteLine(Math.Max(10,15));
            
            System.Console.WriteLine(Math.Pow(3,4));//3^4
            System.Console.WriteLine(Math.Sqrt(9)); // karekok
            System.Console.WriteLine(Math.Log(9));//logaritmik karsiligi
            System.Console.WriteLine(Math.Exp(3));//e uzeri 3 verir
            System.Console.WriteLine(Math.Exp(3));

            
     }
            
    }
}
