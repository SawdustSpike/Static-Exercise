namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            double c = 14.5;
            double f = 73.9;            
            Console.WriteLine($"{TempConverter.FahrenheitToCelsius(f)} & {TempConverter.CelsiusToFahrenheit(c)}");
            // 58.1 f & 23.27778 c

        }
    }
}
