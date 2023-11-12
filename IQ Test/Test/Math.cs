using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class Math : Question
    {
        public int ans1, ans2, ans3, ans4, mathScore = 0;
      
        public override void questions()
        {
            Console.WriteLine("What is the value of 5 + 3 * 2?");
            ans1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What is the square root of 64?");
            ans2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("If x = 3 and y = 4, what is the value of 2x + 3y?");
            ans3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("If the sum of two numbers is 12 and one of the numbers is 8, what is the other number?");
            ans4 = Convert.ToInt32( Console.ReadLine());


        }
        public override int questionCheck()
        {
            if (ans1 == 13)
            {
                mathScore += 10;
            }
            if (ans2 == 8)
            {
                mathScore += 10;
            }
            if (ans3 == 18)
            {
                mathScore += 10;
            }
            if (ans4 == 4)
            {
                mathScore += 10;
            }

            return mathScore;
        }
    }
}
