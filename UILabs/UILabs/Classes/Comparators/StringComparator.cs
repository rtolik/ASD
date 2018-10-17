using System;
using UILabs.Interfaces;

namespace UILabs.Classes.Comparators
{
    public class StringComparator:IComparableLab<char>,IComparableLab<string>
    {
        public StringComparator()
        {
        }

        public bool More(char left, char right)
        {
            return left > right;
        }

        public bool More(string left, string right)
        {
            
            int l = left.Length < right.Length ? left.Length : right.Length;
            for (int i = 0; i < l; i++)
            {
                if (left[i]<right[i])
                {
                    return false;
                }
            }

            return true;
        }

        public bool Less(char left, char right)
        {
            return left < right;
        }

        public bool Less(string left, string right)
        {
            return !More(left, right);
        }

        public bool Equal(char left, char right)
        {
            return left.Equals(right);
        }

        public bool Equal(string left, string right)
        {
            return left.Equals(right);
        }

        public bool MoreEqual(char left, char right)
        {
            if (Equal(left, right) || More(left, right))
                return true;
            return false;
        }

        public bool MoreEqual(string left, string right)
        {
            if (Equal(left, right) || More(left, right))
                return true;
            return false;
        }

        public bool LessEqual(char left, char right)
        {
            if (Equal(left, right) || Less(left, right))
                return true;
            return false;
        }

        public bool LessEqual(string left, string right)
        {
            if (Equal(left, right) || Less(left, right))
                return true;
            return false;
        }

        public bool Less(char left, int right)
        {
            return Less(left, (char) right);
        }

        public bool Less(string left, int right)
        {
            return Less(left, (char)right);
        }

        public bool More(char left, int right)
        {
            return More(left, (char)right);
        }

        public bool More(string left, int right)
        {
            return More(left, (char)right);
        }
    }
}