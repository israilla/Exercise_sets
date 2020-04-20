using System;
using System.Collections.Generic;

namespace Exercise_sets
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> A = new HashSet<int>();
            HashSet<int> B = new HashSet<int>();
            HashSet<int> C = new HashSet<int>();

            Console.WriteLine("O curso A possui quantos alunos?: ");
            int n= int.Parse(Console.ReadLine());

            for (int i =0; i <n; i++)
            {
                int code = int.Parse(Console.ReadLine());
                A.Add(code);
            }

            Console.WriteLine("O curso B possui quantos alunos?: ");
            n = int.Parse(Console.ReadLine());

            for (int j = 0; j < n; j++)
            {
                int code = int.Parse(Console.ReadLine());
                B.Add(code);
            }
            Console.WriteLine("O curso C possui quantos alunos?: ");
            n = int.Parse(Console.ReadLine());

            for (int k = 0; k < n; k++)
            {
                int code = int.Parse(Console.ReadLine());
                C.Add(code);
            }

            HashSet<int> Unir = new HashSet<int>();
            Unir.UnionWith(A);
            Unir.UnionWith(B);
            Unir.UnionWith(C);
            Console.WriteLine("Total de alunos: " + Unir.Count);
            Console.ReadKey();
        }
    }
}
