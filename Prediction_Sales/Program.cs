using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prediction_Sales
{
    public class Program
    {
        static void Main(string[] args)
        {
            double[] salesData = {200000, 300000, 450000, 500000, 600000}; //типа файл с инфой об объеме продаж

            int n = salesData.Length;
            double sumOfMounths = 0;  //X
            double sumOfAllSalesForMounths = 0; //Y
            double sumOfMounthSales = 0;
            double sumOfSquaredMounth = 0;

            for (int i = 0; i < n; i++)
            {
                double x = i + 1; 
                double y = salesData[i];

                sumOfMounths += x;
                sumOfAllSalesForMounths += y;
                sumOfMounthSales += x * y;
                sumOfSquaredMounth += x * x;
            }

            double a = (n * sumOfMounthSales - sumOfMounths * sumOfAllSalesForMounths) / (n * sumOfSquaredMounth - sumOfMounths * sumOfMounths);
            double b = (sumOfAllSalesForMounths - a * sumOfMounths) / n;

            Console.WriteLine("Аналитики прогнозируют нашему компанию объемы продаж для последующих месяцев... ");
            for (int i = 6; i <= 8; i++) //6,7,8 mounth
            {
                double prediction = a * i + b;
                Console.WriteLine($"{i} месяц: {prediction} тенге");
            }
        }
    }
}
