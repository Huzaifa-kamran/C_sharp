using System;
using System.Security.Cryptography.X509Certificates;

namespace Test
{
    internal class AttemptTest
    {
        public int score = 0;
        public int aptitudeScore = 0, englishScore = 0, mathScore = 0, gkScore = 0,bonus = 0;
        public int aptitudeAttempt = 0, englishAttempt = 0, mathAttempt = 0, gkAttempt = 0;

        public void testAttempt()
        {
            Console.Write("Enter Number of attempts: ");
            int attempt = Convert.ToInt32(Console.ReadLine());

            if (attempt == 1)
            {
               


				while (true)
				{
					if (aptitudeAttempt == 0 || englishAttempt == 0 || mathAttempt == 0 || gkAttempt == 0)
					{


						Console.WriteLine("1. Aptitude");
						Console.WriteLine("2. English");
						Console.WriteLine("3. Math");
						Console.WriteLine("4. General Knowledge");
						Console.WriteLine("5. Exit");
						Console.WriteLine("Enter your choice: ");
						int choice = Convert.ToInt32(Console.ReadLine());
						switch (choice)
						{
							case 1:
								if (aptitudeAttempt == 0)
								{
									askQuestion(choice);
								}
								else
								{
									Console.Clear();
									Console.WriteLine("You have already attempted aptitude test");

								}
								break;
							case 2:
								if (englishAttempt == 0)
								{
									askQuestion(choice);
								}
								else
								{
									Console.Clear();
									Console.WriteLine("You have already attempted English test");
								}
								break;

							case 3:
								if (mathAttempt == 0)
								{
									askQuestion(choice);
								}
								else
								{
									Console.Clear();
									Console.WriteLine("You have already attempted Math test");
								}
								break;

							case 4:
								if (gkAttempt == 0)
								{
									askQuestion(choice);
								}
								else
								{
									Console.Clear();
									Console.WriteLine("You have already attempted General Knowledge test");
								}
								break;

							case 5:
								DisplayScore();
								break;
							default:
								Console.WriteLine("Invalid Choice");
								break;
						}
						if (choice == 5)
						{
							break; // Add a break statement here to stop the loop
						}
					}
					else
					{

						DisplayScore();
						break;
					}
				}



			}
			else if(attempt > 1)
            {
				Console.WriteLine("You can attempt the test only once.");

            }
            else
            {
                Console.WriteLine("Invalid Value");
            }
        }
        public void askQuestion(int choice)
        {
            switch(choice)
            {
                case 1:
                    Aptitude aptitude = new Aptitude();
                    aptitude.questions();
                    aptitudeAttempt += 1;
                    aptitudeScore = aptitude.questionCheck();
                    score += aptitudeScore;
                    Console.Clear();
                    break;
               
                case 2:
                    English english = new English();
                    english.questions();
                    englishAttempt += 1;
                    englishScore = english.questionCheck();
                    score += englishScore;
                    Console.Clear();
                    break;
                case 3:
                    Math math = new Math();
                    math.questions();
                    mathAttempt += 1;
                    mathScore = math.questionCheck();
                    score += mathScore;
                    Console.Clear();
                    break;
                case 4:
                    GeneralKnowledge generalKnowledge = new GeneralKnowledge();
                    generalKnowledge.questions();
                    gkAttempt += 1;
                    gkScore = generalKnowledge.questionCheck();
                    score += gkScore;
                    Console.Clear();
                    break;

                

                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }

        //Method for display result
        public void DisplayScore()
        {
            Console.Clear();

            //Display Score
            Console.WriteLine("Your Score is: " + score);

            //Calculate Bonus
            if(score <= 19)
            {
                Console.WriteLine("Bonus Points: " + bonus);
            }else if (score >= 20 && score < 30)
            {
                bonus += 2;
                Console.WriteLine("Bonus Points: " + bonus);
            }else if(score >= 30 && score < 40)
            {
                bonus += 5;
                Console.WriteLine("Bonus Points: " + bonus);
            }else if (score >= 40)
            {
                bonus += 10;
                Console.WriteLine("Bonus Points :" + bonus);
            }

            //Display Bonus Score 
            Console.WriteLine("Your total score is: " + (score + bonus));

            //IQ Level Comments
            if (score <= 19 )
            {
                Console.WriteLine("\'Your IQ level is below average\'");
            }else if (score >= 22 && score < 35)
            {
                Console.WriteLine("\'Your IQ level is average\'");
            }
            else if (score >= 35 && score < 40)
            {
                Console.WriteLine("\'You are intellegent\'");
            }
            else if (score >= 40 )
            {
                Console.WriteLine("\'You are genius\'");
            }else if (score == 0)
            {
                Console.WriteLine("\'You need to re-appear the test\'");
            }
        }
    }
}
