using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branch
{
    /// <summary>
    /// Can insert only new created Branches because returning type links to previous assigned nad it is only referenced not copied.
    /// Depending on task branches can be deep copied
    /// </summary>
    public class Branch
    {
        const int MAXDEPTH = 5;
        public Branch()
        {
            Depth = 1;
            branches = new List<Branch>();
        }
        private int CurrDepth = 0;
        public int Depth { get; set; }
        public List<Branch> branches;

        public Branch AddBranch(Branch branch)
        {
            if (Depth >= MAXDEPTH)
            {
                System.Console.WriteLine("This branch can't be spilt more");
            }
            else
            {
                CurrDepth = Depth;
                if (branches.Count > 0)
                {
                    CurrDepth = branches[0].Depth;
                }
                else if (branches.Count < 1)
                {
                    CurrDepth++;
                }
                branch.Depth = CurrDepth;
                this.branches.Add(branch);

            }
            return branch;
        }
        // To visualize (borrowed code)
        public void PrintPretty(string indent, bool last)
        {
            Console.Write(indent);
            if (last)
            {
                Console.Write("\\-");
                indent += "  ";
            }
            else
            {
                Console.Write("|-");
                indent += "| ";
            }
            Console.WriteLine(Depth);

            for (int i = 0; i < branches.Count; i++)
                branches[i].PrintPretty(indent, i == branches.Count - 1);
        }
    }
}
