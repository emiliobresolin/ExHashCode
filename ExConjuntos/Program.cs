using System;
using System.Collections.Generic;

namespace ExConjuntos
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> courseA = new HashSet<int>();
            HashSet<int> courseB = new HashSet<int>();
            HashSet<int> courseC = new HashSet<int>();
            Console.Write("How many students for course A? ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int y = int.Parse(Console.ReadLine());
                courseA.Add(y);
            }
            Console.Write("How many students for course B? ");
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int y = int.Parse(Console.ReadLine());
                courseB.Add(y);
            }
            Console.Write("How many students for course C? ");
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int y = int.Parse(Console.ReadLine());
                courseC.Add(y);
            }
            HashSet<int> all = new HashSet<int>(courseA);
            all.UnionWith(courseB);
            all.UnionWith(courseC);
            Console.Write("Total students: " + all.Count);
        }
    }
}
