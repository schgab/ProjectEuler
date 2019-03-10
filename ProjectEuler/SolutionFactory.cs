using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectEuler.Problems;

namespace ProjectEuler
{
    static class SolutionFactory
    {
        private static Dictionary<int, Type> SolvedProblems = new Dictionary<int, Type>()
        {
            { 1, typeof(Problem1) },
        };



        public static IProblem GetSolutionTo(int problemNr)
        {
            if (SolvedProblems.ContainsKey(problemNr))
            {
                return (IProblem) Activator.CreateInstance(SolvedProblems[problemNr]);
            }
            return new NotSolved();
        }
    }
}
