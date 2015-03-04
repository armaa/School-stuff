using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] FirstNumber;
            int[] SecondNumber;
            int First = 0;
            int Second = 0;
            int Sum = 0;
            int lengthFirst = 0;
            int lengthSecond = 0;

            Console.WriteLine("Insert first number: ");
            First = int.Parse(Console.ReadLine());
            lengthFirst = NumberLength(First);
            FirstNumber = new int[lengthFirst];

            Console.WriteLine("Insert second number: ");
            Second = int.Parse(Console.ReadLine());
            lengthSecond = NumberLength(Second);
            SecondNumber = new int[lengthFirst];


            FirstNumber = ToBit(First, lengthFirst);
            SecondNumber = ToBit(Second, lengthSecond);
            Sum = SumBitNumbers(FirstNumber, lengthFirst, SecondNumber, lengthSecond);
        }

        private static int SumBitNumbers(int[] FirstNumber, int lengthFirst, int[] SecondNumber, int lengthSecond)
        {
            int Sum = 0;
            int[] SumNumber;
            int lengthSum = 0;

            if (lengthFirst > lengthSecond)
            {
                lengthSum = lengthFirst + 2;
                SumNumber = new int[lengthSum];
            }

            else
            {
                lengthSum = lengthSecond + 2;
                SumNumber = new int[lengthSum];
            }

            int[] temp = new int[lengthSum];

            for (int i = 0; i < lengthSum; i++)
            {

            }


            return Sum;
        }

        private static int[] ToBit(int Number, int lengthNumber)
        {
            int[] arrayNumber = new int[lengthNumber];

            for (int i = 0; i < lengthNumber; i++)
            {
                arrayNumber[i] = Number % 2;
                Number /= 2;
            }

            return arrayNumber;
        }

        private static int NumberLength(int Number)
        {
            int length = 0;

            do
            {
                length++;
                Number /= 10;
            } while (Number != 0);

            return length;
        }
    }
}
