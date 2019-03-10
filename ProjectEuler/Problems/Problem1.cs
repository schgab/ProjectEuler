using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ProjectEuler.Problems
{
    class Problem1 : IProblem
    {
        public TimeSpan ElapsedTime { get; set; }

        public string Solution()
        {
            Stopwatch st = new Stopwatch();
            st.Start();
            int sum = Enumerable.Range(0, 1000).Where(x => x % 3 == 0 || x % 5 == 0).Sum();
            st.Stop();
            ElapsedTime = st.Elapsed;
            return sum.ToString();
        }
    }
}
