using System;

namespace StaticExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What temp in Farenheight to convert:");
            double temp = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"\n{temp} degrees Farenheight is {TempConverter.FarenheightToCelcius(temp)} degrees Celcius");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("What temp in Celcius would you like to convert:");
            temp = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"\n{temp} degrees Celcius is {TempConverter.CelciusToFarenheight(temp)} degrees Farenheight.");
        }
    }
}
