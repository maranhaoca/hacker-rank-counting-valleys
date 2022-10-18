using System.Net;
using System.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Src
{
    public class Result
    {
        /*
         * Complete the 'countingValleys' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts following parameters:
         *  1. INTEGER steps
         *  2. STRING path
         */

        public static int countingValleys(int steps, string path)
        {
            int altitude = 0;
            int count = 0;
            bool entryVale = false;

            for (int i = 0; i < path.Length; i++)
            {
                altitude = path[i] == 'U' ? altitude += 1 : altitude -= 1;                

                if (path[i] == 'D' && altitude == -1)
                {
                    entryVale = true;

                }
                if (path[i] == 'U' && altitude == 0 && entryVale)
                {
                    count++;
                    entryVale = false;
                }
            }

            return count;
        }
    }
}