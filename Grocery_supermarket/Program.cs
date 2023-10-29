using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grocery_supermarket
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] products = {"Хлеб", "Доширак", "Яйца", "Молоко", "Чипсы"};
            double[] prices = {200.0, 190.0, 570.0, 228.0, 700.0};

            DateTime currentTime = DateTime.Now;

            bool isDiscountApplied = currentTime.Hour >= 8 && currentTime.Hour < 12;

            Console.WriteLine("Продукты в магазе: ");
            for(int i = 0; i < products.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {products[i]} - {prices[i]} тенге");
            }
            Console.WriteLine("Выберите продукты для покупки (введите номера через пробел):");
            string input = Console.ReadLine();
            string[] productNumbers = input.Split(' ');

            double totalSumma = 0;
            foreach(string number in productNumbers)
            {
                if (int.TryParse(number, out int productNumber) && productNumber >= 1 && productNumber <= products.Length)
                {
                    totalSumma += prices[productNumber - 1];
                }
                else
                {
                    Console.WriteLine($"Продукт с номером {productNumber} не существует.");
                }
            }
            if (isDiscountApplied)
            {
                double discount = totalSumma % 5;
                totalSumma -= discount;
                Console.WriteLine("Вам предоставлена скидка 5%!");
            }

          
            Console.WriteLine($"Итоговая сумма: {totalSumma} тенге.");
        }
    }
}
