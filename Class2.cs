using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_exercise
{
    class Converter
    {

        public double grn = 1;
        public double usd = 41;
        public double eur = 36;
        public double rub = 0.67;

            public  Converter(double usdx, double eurx, double rubx)
            {
                usd = usdx;
                eur = eurx;
                rub = rubx;
            }

        public void Choice()
        {
            Console.Write("How much grn do you have?:");

            double grn = Convert.ToDouble(Console.ReadLine());

            Console.Write("if you want convert grn into usd press - 1\ninto eur prees - 2\ninto rub press - 3\n");

            Console.Write("If you want convert usd into grn press - 4\neur into grn press - 5\nrub into grn- 6\n>>>");

            int pick = Convert.ToInt32(Console.ReadLine());

            switch (pick)
            {

                case 1:
                    Console.Write($"You have: {Math.Round(grn / 41)} usd\n");
                return;

                case 2:
                    Console.Write($"You have: {Math.Round(grn / 36)} eur\n");
                break;

                case 3:
                    Console.Write($"You have: {Math.Round(grn * 6.7)} rub\n");
                break;

                case 4:
                    Console.Write("How much usd do you have?: ");

                double usd = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine($"You have: {Math.Round(usd * 41)} grn");
                    break;                                    

                case 5:
                    Console.Write("How much eur do you have?: ");

                double eur = Convert.ToDouble(Console.ReadLine());

                Console.Write($"You have: {Math.Round(eur * 36)} grn\n");
                break;

                case 6:
                    Console.Write("How much rub do you have?: ");

                double rub = Convert.ToDouble(Console.ReadLine());

                Console.Write($"You have: {Math.Round(rub / 6.7)} grn\n\n\n");

                break;
                default:

                    Console.WriteLine("Wrong choice -_-");

                    break;

            } 
        }
    }
}