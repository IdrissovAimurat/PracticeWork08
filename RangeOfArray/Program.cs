using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RangeOfArray
{
    public class Program
    {
        static void Main(string[] args)
        {
            RangeOfArray array = new RangeOfArray(6, 10);
            for (int i = 6; i <= 10; i++)
            {
                array[i] = i * 10;
            }
            for (int i = 6; i <= 10; i++)
            {
                Console.WriteLine($"array[{i}] = {array[i]}");
            }
            try
            {
                int value = array[12]; // index вне границ 6 и 10
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
