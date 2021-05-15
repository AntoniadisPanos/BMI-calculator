using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI_calculator
{
    class Program
    {
        static void Main(string[] args)
        {



            Console.Write("Enter your Height in M: ");
            double ht = Convert.ToDouble(Console.ReadLine());

            while (ht < 0.5 || ht > 2.0)
            {
                Console.Write("Enter a valid Height: ");
                ht = Convert.ToDouble(Console.ReadLine());
            }
            Console.Write($"Your Height is {ht}\n");

            Console.Clear();
            Console.Write("Enter your Weight in KG: ");
            double wg = Convert.ToDouble(Console.ReadLine());

            while (wg < 0)
            {
                Console.Write("Enter a valid Weight: ");
                wg = Convert.ToInt32(Console.ReadLine());
            }
            Console.Clear();
            Console.Write($"Your Weight is {wg}\n\n");
            Console.WriteLine(BMIcalculation(ht, wg));

        }

        private static string BMIcalculation(double ht, double wg)
        {
            Console.Clear();
            double BMI = wg / (ht * ht);
            BMI = wg / (ht * ht);
            if (BMI <= 18.5)
            {
                return "You are UnderWeight";

            }
            else if (BMI >= 18.5 && BMI <= 24.9)
            {
                return "Your Weight is normal";
            }

            else if (BMI >= 25 && BMI <= 29.9)
            {
                return "You are overweighted";
            }

            else 
            {
                return "You are obecity";
            }
            
        }
    }
}
