using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Problems
{
    class NotSolved : IProblem
    {
        public TimeSpan ElapsedTime { get => new TimeSpan(0); set => new TimeSpan(0); }

        public string Solution()
        {
            return "Not solved yet";
        }
    }
}
