using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class Aptitude : Question
    {
        public int ans1, ans2, ans3, aptitudeScore = 0;
        public string ans4;
        public override void questions()
        {
            Console.WriteLine("What is the next number in the sequence: 2, 4, 8, 16, ___?");
             ans1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("If 6 pens and 8 pencils cost $90, and 4 pens and 7 pencils cost $76, " +
                               "what is the cost of 5 pens and 9 pencils?");
             ans2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("If a car covers a distance of 540 km in 10 hours, what is the average speed of the car in km per hour?");
            ans3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("If the day after tomorrow is four days before Friday, what day is it today?");
             ans4 = Console.ReadLine();

           
        }
        public override int questionCheck()
        {
            if(ans1 == 32)
            {
                aptitudeScore += 10;
            }
            if (ans2 == 86)
            {
                aptitudeScore += 10;
            }
            if (ans3 == 54)
            {
                aptitudeScore += 10;
            }
            if (ans4.ToLower() == "tuesday")
            {
                aptitudeScore += 10;
            }

            return aptitudeScore;
        }
   
    }
}
