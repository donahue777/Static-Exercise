namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var celsius = TempConverter.FahrenheitToCelsius(64.2);

            Console.WriteLine($"{celsius} degrees celsius");

            var fahrenheit = TempConverter.CelsiusToFahrenheit(14.7);

            Console.WriteLine($"{fahrenheit} degrees fahrenheit");
        }
    }
}
