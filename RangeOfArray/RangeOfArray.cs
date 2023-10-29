using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RangeOfArray
{
    public class RangeOfArray
    {
        private int[] array;
        private int startIndex;
        private int endIndex;
        private int length;

        public RangeOfArray(int startIndex, int endIndex)
        {
            if (startIndex > endIndex)
            {
                throw new ArgumentException("Конечный индекс должен быть больше начального индекса");
            }
            this.startIndex = startIndex;
            this.endIndex = endIndex;
            this.length = endIndex - startIndex + 1;
            this.array = new int[length];

        }
        public int this [int index]
        {
            get
            {
                if (IsIndexValid(index))
                {
                    return array[index - startIndex];
                }
                else
                {
                    throw new IndexOutOfRangeException("Индекс вне границ");
                }
            }
            set
            {
                if (IsIndexValid(index))
                {
                    array[index - startIndex] = value;
                }
                else
                {
                    throw new IndexOutOfRangeException("Индекс вне границ");
                }
            }
        }
        private bool IsIndexValid(int index)
        {
            return index >= startIndex && index < endIndex;
        }
    }
}
