using StaticExercise;

var celsius = TempConverter.FahrenheitToCelsius(100);
var fahrenheit = TempConverter.CelsiusToFahrenheit(0);

Console.WriteLine("Temperature Conversion - Fahrenheit || Celsius");
Console.WriteLine("-----------------------------------------------------\n");
Console.WriteLine($"°F to °C = {celsius}");
Console.WriteLine($"°C to °F = {fahrenheit}");
Console.WriteLine();
Console.WriteLine();

Console.WriteLine("USER INPUT - Temperature Conversion - Fahrenheit || Celsius");
Console.WriteLine("-----------------------------------------------------\n");
Console.Write($"What temperature in Fahrenheit would you like to convert to Celsius? "); 
double x = double.Parse(Console.ReadLine()); 
Console.WriteLine($"The conversion of your Fahrenheit to Celsius of {x} degrees is {celsius} Celsius");
Console.WriteLine();

Console.Write($"What temperature in Celsius would you like to convert to Fahrenheit? "); 
double y = double.Parse(Console.ReadLine());
Console.WriteLine($"The conversion of your Celsius to Fahrenheit of {y} degrees is {fahrenheit} Fahrenheit");