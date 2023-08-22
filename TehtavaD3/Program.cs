using System;

namespace BasicCalculations
{
    class Program
    {
        static Tuple<double, double, double, double> PerformBasicCalculations(double a, double b)
        {
            // Suorita peruslaskutoimitukset
            double sum = a + b;
            double difference = a - b;
            double product = a * b;
            double quotient = b != 0 ? a / b : double.PositiveInfinity; // Käsitellään nollalla jakaminen

            // Palauta tulokset tuple-muodossa
            return new Tuple<double, double, double, double>(sum, difference, product, quotient);
        }

        static void Main(string[] args)
        {
            Console.Write("Syötä ensimmäinen luku: ");
            double number1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Syötä toinen luku: ");
            double number2 = Convert.ToDouble(Console.ReadLine());

            // Suorita peruslaskutoimitukset
            Tuple<double, double, double, double> results = PerformBasicCalculations(number1, number2);

            // Tulosta tulokset
            Console.WriteLine($"Yhteenlasku: {results.Item1}");
            Console.WriteLine($"Vähennyslasku: {results.Item2}");
            Console.WriteLine($"Kertolasku: {results.Item3}");
            Console.WriteLine($"Jakolasku: {results.Item4}");
        }
    }
}
