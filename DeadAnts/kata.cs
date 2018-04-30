using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeadAnts
{
    public  class kata
    {
        public  int DeadAntCount(string ants)
        {
            if (ants == null)
                return 0;
            var deadAnts = ants.Replace("ant", "");
            var aCount = 0;
            var nCount = 0;
            var tCount = 0;
            var ans = 0;
            if (deadAnts != null)
            {
                foreach (var part in deadAnts)
                {
                    if (part == 'a')
                        aCount++;
                    if (part == 'n')
                        nCount++;
                    if (part == 't')
                        tCount++;
                }
                if (aCount >= nCount && aCount >= tCount)
                    ans = aCount;
                if (nCount >= aCount && nCount >= tCount)
                    ans = nCount;
                if (tCount >= aCount && tCount >= nCount)
                    ans = tCount;
            }
            return ans;
        }
    }
}
