using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StaticExercise; 

//Exercise 1:
//Create a new console app called StaticExercise.

//Now create a static class called TempConverter.The class should have at least 2 methods, one called FahrenheitToCelsius that will require a double as a parameter
//and return a double, the other CelsiusToFahrenheit which will also require a double as a parameter and return a double.

//Fill out these methods and call them in your Program.cs file. Make sure they’re accurate!

namespace StaticExercise
{
    public static class TempConverter
    {
        public static double FahrenheitToCelsius (double fahrenheit) 
        {
            return (fahrenheit - 32) / 1.8;
        }

        public static double CelsiusToFahrenheit (double celsius)
        {
            return (celsius * 9) / 5 + 32;
        }
    }
}
