using System;
using System.Collections.Generic;
using System.Text;

namespace StaticExercise
{
    class TempConverter
    {
        TempConverter()
        {
        }
        public static double CelciusToFarenheight(double temp)
        {
            temp = (temp * 9 / 5) + 32;
            return temp;
        }
        public static double FarenheightToCelcius(double temp)
        {
            temp = (temp - 32) * 5 / 9;
            return temp;
        }
    }
}
