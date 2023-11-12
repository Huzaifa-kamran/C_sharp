using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class English : Question
    {
        public int englishScore = 0;
        public string ans1, ans2, ans3, ans4;
        public override void questions()
        {
            Console.WriteLine("What is the plural form of the word \"child\"?");
            ans1 =Console.ReadLine();

            Console.WriteLine("Which of the following is a synonym for \"happy\"?");
            ans2 = Console.ReadLine();

            Console.WriteLine("What is the past tense of the verb \"go\"?");
            ans3 = Console.ReadLine();

            Console.WriteLine("What is the opposite of the word \"brave\"?");
            ans4 = Console.ReadLine();


        }
        public override int questionCheck()
        {
            if (ans1.ToLower() == "children")
            {
                englishScore += 10;
            }
            if (ans2.ToLower() == "joyful")
            {
                englishScore += 10;
            }
            if (ans3.ToLower() == "went")
            {
                englishScore += 10;
            }
            if (ans4.ToLower() == "cowardly")
            {
                englishScore += 10;
            }


            return englishScore;
        }

    }
}
