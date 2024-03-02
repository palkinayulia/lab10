using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary10Lab
{
    public class SortByYear : IComparer
    {
        public int Compare(object? x, object? y)
        {
            Watch clock1 = x as Watch;
            Watch clock2 = y as Watch;
            if (clock1.YearIssue < clock2.YearIssue) return -1;
            else
                if (clock1.YearIssue == clock2.YearIssue) return 0;
            else
            {
                return 1;
            }
        }
    }
}
