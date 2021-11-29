using System;

namespace Open_Lab_02._02
{
    public class Formatter
    {
        public void Format(double numbers)
        {
            double a = Math.Round(numbers, 2);
            Console.WriteLine(numbers);
        }
    }
}
