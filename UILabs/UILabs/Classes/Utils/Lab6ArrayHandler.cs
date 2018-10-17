using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UILabs.Classes.Utils
{
    class Lab6ArrayHandler
    {
        public static int[] Execute(int[] array)
        {
            List<int> arrList = array.ToList();
            for (int i = 0; i < arrList.Count; i++)
            {
                if (arrList[i] % 3 == 0)
                {
                    arrList.Remove(arrList[i]);
                    i--;
                }
                else
                {
                    arrList[i] *= arrList[i];
                }
            }
           
            return arrList.ToArray();
        }
    }
}
