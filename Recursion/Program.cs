using System;
using Branch;
namespace Recursion
{
    class Program
    {
        /// <summary>
        /// With minimal test case. Branches were kinda confusing need some more info
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Branch.Branch b1 = new Branch.Branch();

            b1.AddBranch(new Branch.Branch());
            Branch.Branch b11 = b1.AddBranch(new Branch.Branch());
            b11.AddBranch(new Branch.Branch());
            Branch.Branch b2 = b1.AddBranch(new Branch.Branch());
            b2.AddBranch(new Branch.Branch());
            Branch.Branch b3 = b2.AddBranch(new Branch.Branch());
            b3.AddBranch(new Branch.Branch());
            Console.WriteLine(FindDepth(b1, 0));
            b1.PrintPretty("", true);
        }

        public static int FindDepth(Branch.Branch root, int current)
        {
            if (root.branches.Count < 1) return root.Depth;
            foreach(var branch in root.branches)
            {
                current = FindDepth(branch,branch.Depth);
            }
            return current;
        }
    }
}
