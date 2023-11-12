using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class GeneralKnowledge : Question
    {
        public int gkScore = 0;
        public string ans1, ans2, ans3, ans4;
        public override void questions()
        {
            Console.WriteLine("What is the capital of France?");
            ans1 = Console.ReadLine();

            Console.WriteLine("Which planet is known as the \"Red Planet\"?");
            ans2 = Console.ReadLine();

            Console.WriteLine("Who is the current President of the United States?");
            ans3 = Console.ReadLine();

            Console.WriteLine("What is the largest ocean on Earth?");
            ans4 = Console.ReadLine();


        }
        public override int questionCheck()
        {
            if (ans1.ToLower() == " aris")
            {
                gkScore += 10;
            }
            if (ans2.ToLower() == "mars")
            {
                gkScore += 10;
            }
            if (ans3.ToLower() == " joe biden")
            {
                gkScore += 10;
            }
            if (ans4.ToLower() == " pacific ocean")
            {
                gkScore += 10;
            }


            return gkScore;
        }
    }
}
