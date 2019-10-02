using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI
{
    class Program
    {
        static void Main(string[] args)
        {
            double BMI, Größe, Masse;

            Console.WriteLine("Aus Größe und Masse soll der BMI berechnet werden");
            Console.WriteLine("Masse in kg angeben:");
            Masse = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Größe in m angeben:");
            Größe = Convert.ToDouble(Console.ReadLine());

            BMI = Masse / Math.Pow(Größe,2);
            BMI = Math.Round(BMI, 1);

            if (BMI < 16)
            {
                Console.WriteLine("Der BMI beträgt {0}, das bedeutet Starkes Untergewicht", BMI);
            }
            else if (BMI <= 17)
            {
                Console.WriteLine("Der BMI beträgt {0}, das bedeutet Mäßiges Untergewicht", BMI);
            }
            else if (BMI <= 18.5)
            {
                Console.WriteLine("Der BMI beträgt {0}, das bedeutet Leichtes Untergewicht", BMI);
            }
            else if (BMI <= 25)
            {
                Console.WriteLine("Der BMI beträgt {0}, das bedeutet Normalgewicht", BMI);
            }
            else if (BMI <= 30)
            {
                Console.WriteLine("Der BMI beträgt {0}, das bedeutet Präadipositas", BMI);
            }
            else if (BMI <= 35)
            {
                Console.WriteLine("Der BMI beträgt {0}, das bedeutet Adipositas Grad I ", BMI);
            }
            else if (BMI < 40)
            {
                Console.WriteLine("Der BMI beträgt {0}, das bedeutet Adipositas Grad II ", BMI);
            }
            else
            {
                Console.WriteLine("Der BMI beträgt {0}, das bedeutet Adipositas Grad III ", BMI);
            }
        }
    }
}
