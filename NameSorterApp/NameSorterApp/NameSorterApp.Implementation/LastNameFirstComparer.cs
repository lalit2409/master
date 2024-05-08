using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameSorterApp.Implementation
{
    public class LastNameFirstComparer : IComparer<string>
    {
        public int Compare(string x, string y)
        {
            string[] xNameParts = x.Split(' ');
            string[] yNameParts = y.Split(' ');

            string xLastName = xNameParts.Last();
            string yLastName = yNameParts.Last();

            return string.Compare(xLastName, yLastName, StringComparison.InvariantCulture);
        }
    }
}
