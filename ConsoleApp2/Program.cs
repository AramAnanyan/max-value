
using System;
using System.Text;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = 0, max=0, l=0;
            string a = Console.ReadLine();
            for (int j = 0; j < a.Length; j++)
            {
                for (int i = 0; i < a.Length; i++)
                {
                    if (a[i] == a[j])
                    {
                        k++;
                    }
                }
                if (k > max)
                {
                    max = k;
                    l = j;
                }
                k = 0;
            }
            Console.WriteLine(a[l]);
            //StringBuilder sb = new StringBuilder();
            //var lengt = sb.Length;
            //Console.WriteLine(lengt);
            //var capa = sb.Capacity;
            //Console.WriteLine(capa);

        }
    }
}
