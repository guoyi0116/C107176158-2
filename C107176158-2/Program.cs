using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C107176158_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] name=new string[5];
            int[] scores = new int[5];
           

            for(int i = 0; i <name.Length; i++)
            {
                Console.WriteLine("第{0}號同學",i + 1);
                name[i] = Console.ReadLine();
                Console.WriteLine("{0}號同學的成績是:",i+1);
                Convert.ToInt32(Console.ReadLine());

            }
            Array.Sort(scores, name);
            Array.Reverse(scores);
            Array.Reverse(name);
            for (int j = 0; j < name.Length; j++) 
            {
                Console.WriteLine("{0}的成績是{1}", name[j], scores[j]);

            }
            Console.Read();
        }
    }
}
