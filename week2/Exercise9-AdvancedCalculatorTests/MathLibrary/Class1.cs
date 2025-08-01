﻿namespace MathLibrary
{
    public class Calculator
    {
        private int result;

        public int Add(int a, int b)
        {
            result = a + b;
            return result;
        }

        public int Subtract(int a, int b)
        {
            result = a - b;
            return result;
        }

        public int Multiply(int a, int b)
        {
            result = a * b;
            return result;
        }

        public int Divide(int a, int b)
        {
            if (b == 0)
                throw new ArgumentException("Cannot divide by zero");
            result = a / b;
            return result;
        }

        public void AllClear()
        {
            result = 0;
        }

        public int GetResult => result;
    }
}
