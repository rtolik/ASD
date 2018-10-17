using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UILabs.Classes.Exeptions
{
    public class NoComparatorExeption:ApplicationException
    {
        public NoComparatorExeption():base("There is no Comparator for this type!!!")
        {
        }
    }
}
