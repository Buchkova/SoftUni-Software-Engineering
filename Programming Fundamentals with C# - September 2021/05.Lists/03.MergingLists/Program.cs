using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.MergingLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> N = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> M = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> combinated = new List<int>();

            if (N.Count < M.Count)
            {
                for (int i = 0; i < N.Count; i++)
                {

                    combinated.Add(N[i]);
                    combinated.Add(M[i]);

                }
                for (int i = N.Count; i < M.Count; i++)
                {
                    combinated.Add(M[i]);
                }
            }
            else if (N.Count > M.Count)
            {
                for (int i = 0; i < M.Count; i++)
                {

                    combinated.Add(N[i]);
                    combinated.Add(M[i]);

                }
                for (int i = M.Count; i < N.Count; i++)
                {
                    combinated.Add(N[i]);
                }
            }
            else
            {
                for (int i = 0; i < N.Count; i++)
                {

                    combinated.Add(N[i]);
                    combinated.Add(M[i]);

                }
            }
                Console.WriteLine(string.Join(" ", combinated));
        }

        
    }
}
