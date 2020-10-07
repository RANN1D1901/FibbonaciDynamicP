using System;
using System.Diagnostics;

using System.Collections.Generic;

namespace DynamicFibo
{
    class Program
    {
        List<int> memo = new List<int>();
        public Program(int n)
        {
            
            for (int i = 0; i <n; i++)
                memo.Add(-1);
        }

        public int fib(int n)
        {
            if (n == 0 || n == 1)
                return n;
            else
                return fib(n - 1) + fib(n - 2);
        }
        public int dynamicFib(int n)
        {
            
            if(memo[n]==-1)
            {
                int result;
                if (n == 0||n==1)
                {
                    result = n;
                }
                else
                {
                    result = dynamicFib(n - 1) + dynamicFib(n - 2);
                    
                }
                memo[n] = result;

            }
            return memo[n];

            

        }
        static void Main(string[] args)
        {
            for(int i=0;i<20;i++)
            {
                Console.WriteLine("Fibonacci Number:"+(31+ i));
                Program p = new Program(32+i);

                Stopwatch sw = new Stopwatch();

                sw.Start();

                Console.Write((p.dynamicFib(31+i)+"             |              "));

                sw.Stop();

                Console.WriteLine("Elapsed={0}", sw.Elapsed);


                sw.Start();
                Console.Write(p.fib(31+i)+ "             |              ");
                sw.Stop();
                Console.WriteLine("Elapsed={0}", sw.Elapsed);

                
            }
            Console.ReadLine();


        }
    }
}
