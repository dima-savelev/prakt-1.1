using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib_13
{
    public class Practice
    {
        public static void Power(out string numbers, out string results)
        {
            Random randomNumber = new Random();
            double x = int.MinValue;
            double copyX;
            numbers = string.Empty;
            results = string.Empty;
            do
            {
                copyX = x;
                x = randomNumber.Next(-5, 5);
                numbers += Convert.ToString(x) + "; ";

                double currentResult = default;

                if (x > 0)
                {
                    currentResult = Math.Round(Math.Sqrt(x), 2);
                }
                if (x <= 0)
                {
                    currentResult = Math.Pow(x, 2);
                }
                results += Convert.ToString(currentResult) + "; ";

            } while (x != copyX);

            RemoveLastSeporator(ref numbers, ref results);
        }

        private static void RemoveLastSeporator(ref string numbers, ref string results)
        {
            numbers = numbers.Remove(numbers.LastIndexOf(";"));
            results = results.Remove(results.LastIndexOf(";"));
        }
    }
}
