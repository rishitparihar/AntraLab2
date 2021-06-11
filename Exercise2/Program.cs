using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    class Solution

    {

        List<int> myInts = new List<int>();
        int size;

        public void GetData()
        {
         
            Console.WriteLine("enter size:");
            size = Convert.ToInt32(Console.ReadLine());
            int temp = 0;

            for (int i = 0; i < size; i++)
            {
                Console.WriteLine($"enter element for {i} index");
                temp = Convert.ToInt32(Console.ReadLine());
                myInts.Add(temp);
            }

        }

        public void Display()
        {
            int[] A = myInts.ToArray();
            int output = solution(A);
            Console.WriteLine($"The result is : {output}");
        }
        public int solution(int[] A)
        {
            var groupped = A
               .GroupBy(x => x)
               .OrderByDescending(grp => grp.Count())
               .FirstOrDefault();

            int toReturn = groupped.Key;
            return toReturn;
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
