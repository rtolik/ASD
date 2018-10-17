using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UILabs.Interfaces;

namespace UILabs.Classes.Comparators
{
    public class NumberComparator:IComparableLab<double>,IComparableLab<float>,IComparableLab<int>
    {
        public NumberComparator()
        {
        }

        public bool More(double left, double right)
        {
            return left > right;

        }
               
        public bool More(float left, float right)
        {
            return left > right;

        }

        public bool More(int left, int right)
        {   
            return left > right;
        }

        public bool Less(double left, double right)
        {
            return left < right;
        }

        public bool Less(float left, float right)
        {
            return left < right;
        }

        public bool Less(int left, int right)
        {
            return left < right;
        }

        public bool Equal(double left, double right)
        {
            return left.Equals(right);
        }

        public bool Equal(float left, float right)
        {
            return left.Equals(right);
        }

        public bool Equal(int left, int right)
        {
            return left.Equals(right);
        }

        public bool MoreEqual(double left, double right)
        {
            return left >= right;
        }

        public bool MoreEqual(float left, float right)
        {
            return left >= right;

        }

        public bool MoreEqual(int left, int right)
        {
            return left >= right;
        }

        public bool LessEqual(double left, double right)
        {
            return left <= right;
        }

        public bool LessEqual(float left, float right)
        {
            return left <= right;
        }

        public bool LessEqual(int left, int right)
        {
            return left <= right;
        }

        public bool Less(double left, int right)
        {
            return left <= right;
        }

        public bool Less(float left, int right)
        {
            return left <= right;
        }

        public bool More(double left, int right)
        {
            return left >= right;
        }

        public bool More(float left, int right)
        {
            return left >= right;
        }
    }
}
