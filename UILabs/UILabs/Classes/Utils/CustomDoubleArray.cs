using System;

namespace UILabs.Classes.Utils
{
    public class CustomDoubleArray
    {
        public CustomDoubleArray()
        {
            Arr=new double[0];
        }

        public double[] Arr
        {
            get; set;
        }

        public double ArrEl => Arr[0];

        public double MaxArrEl
        {
            get => FindMax(out _);

            set
            {
                FindMax(out int ind);
                Arr[ind] = value;
            }
        }

        private double FindMax( out int index)
        {
            double max = Arr[0];
            index = 0;
            for (int i = 1; i < Arr.Length; i++)
            {
                if (Arr[i] > max)
                {
                    max = Arr[i];
                    index = i;
                }
            }

            return max;
        }

        public CustomDoubleArray(double[] arrEl)
        {
            Arr = arrEl;
        }

        public override string ToString()
        {
            string result="";
            foreach (double el in Arr)
            {
                result += el + "   ";
            }

            return result + "\n";
        }

    }
}