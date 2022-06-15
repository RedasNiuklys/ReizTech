using System;
using Branch;

namespace Branch
{
    class Program
    {
        static void Main(string[] args)
        {
            Branch b1 = new Branch();
            Branch b2 = new Branch();
            Branch b3 = new Branch();
            Branch b4 = new Branch();
            Branch b5 = new Branch();
            Branch b6 = new Branch();
            Branch b11 = b1.AddBranch(b2);
            Branch b12 = b1.AddBranch(b3);

            b11.AddBranch(b4);
            b12.AddBranch(b5);
            b12.AddBranch(b6);
            b1.PrintPretty("", true);
        }
    }
}
