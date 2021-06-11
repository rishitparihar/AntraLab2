using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    class Solution
    {
        int A, B;

        public int solution(int A, int B)
        {
            int count = 0;
            for (int i = A; i <= B; i++)
            {
                if (Math.Sqrt(i) == (int)Math.Sqrt(i))
                {
                    count += 1;
                }
            }

            return count;
        }

        public void GetData()
        {
            Console.WriteLine("enter A:");
            A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter B:");
            B = Convert.ToInt32(Console.ReadLine());
        }

        public void Display()
        {
            int OutPut = solution(A, B);
            Console.WriteLine(OutPut);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();

            s.GetData();
            s.Display();

            Console.ReadLine();
        }
    }
}
