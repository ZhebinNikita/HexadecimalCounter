using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexadecimalCounter
{
    

    class HexadecimalCounter
    {

        private int number;
        private static int leftBorder, rightBorder;



        public static void SetBorders(int a, int b)
        {
            if (a >= 0 && b > 1)
            {
                leftBorder = a;
                rightBorder = b;
            }
            else
            {
                leftBorder = 0;
                rightBorder = 100;
            }
        }



        public HexadecimalCounter()
        {
            if (number > leftBorder && number < rightBorder)
                number = 1;

            else throw new IndexOutOfRangeException();
        }
        public HexadecimalCounter(int number)
        {
            if (number > leftBorder && number < rightBorder)
                this.number = number;

            else throw new IndexOutOfRangeException();
        }



        private int Number
        {
            get
            {
                return number;
            }
        }
        public string HexNumber
        {
            get
            {
                return Convert.ToString(Number, 16);
            }
        }



        public void Decrement()
        {
            number--;
            if (number < leftBorder || number >= rightBorder)
                throw new IndexOutOfRangeException();
        }


        public void Increment()
        {
            number++;
            if (number < leftBorder || number >= rightBorder)
                throw new IndexOutOfRangeException();
        }


        public void ShowNumber()
        {
            Console.WriteLine("Current value: " + Convert.ToString(Number, 16));
        }
    }






    class Program
    {
        static void Main(string[] args)
        {
            HexadecimalCounter.SetBorders(0, 200);

            HexadecimalCounter someNum = new HexadecimalCounter(1);
            someNum.ShowNumber();



            // examples
            for (int i = 0; i < 20; i++) // set > 200 // выход за пределы
            {
                someNum.Increment();
                Console.WriteLine(someNum.HexNumber);
            }


            for (int i = 0; i < 20; i++)
            {
                someNum.Decrement();
                Console.WriteLine(someNum.HexNumber);
            }

            
            Console.ReadKey();
        }
    }
}
