using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PredictionSales
{
    public class Program
    {
        static void Main(string[] args)
        {
            double[] salesData = { 100, 120, 140, 160, 180 };

            int n = salesData.Length;
            double sumX = 0;
            double sumY = 0;
            double sumXY = 0;
            double sumX2 = 0;

            for (int i = 0; i < n; i++)
            {
                double x = i + 1;
                double y = salesData[i];

                sumX += x;
                sumY += y;
                sumXY += x * y;
                sumX2 += x * x;
            }


            double a = (n * sumXY - sumX * sumY) / (n * sumX2 - sumX * sumX);
            double b = (sumY - a * sumX) / n;


            for (int i = 4; i <= 6; i++)
            {
                double forecast = a * i + b;
                Console.WriteLine($"Прогноз объема продаж для месяца {i}: {forecast}");
            }
        }
    }
}
