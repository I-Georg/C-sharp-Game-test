using System;

namespace sample1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fun quiz.Time to find out your next destination.Pick a colour: red, gray or blue");
			string colour = Console.ReadLine();
			const string red = "red";
			const string gray = "gray";
			const string blue = "blue";
			string redAnswer;
			string grayAnswer;
			string blueAnswer;
			switch (colour)
			{
				case red:
				{
					Console.ForegroundColor = ConsoleColor.Red;
					Console.WriteLine("You picked red. Now sweet or salty?");
					redAnswer = Console.ReadLine();
					if(redAnswer == "sweet")
					{
						Console.WriteLine("Your next travel should be Paris.");
					}
					
					else if (redAnswer == "salty")
					{
						Console.WriteLine("Your next destination should be Amsterdam.");
					}
					else
					{
						Console.WriteLine("Invalid answer;");
					}
					Console.ResetColor();
					break;
					
				}
				case gray:
				{
					Console.ForegroundColor = ConsoleColor.DarkGray;
					Console.WriteLine("You picked pink. Now pick a season: summer or winter?");
					grayAnswer = Console.ReadLine();
					if(grayAnswer == "summer")
					{
						Console.WriteLine("Your next travel should be Brussels.");
					}
					else if (grayAnswer == "winter")
					{
						Console.WriteLine("Your next destination should be Arco,Italy");
					}
					else
					{
						Console.WriteLine("Invalid answer;");
					}
					Console.ResetColor();
					break;
					
				}
				case blue:
				{
					Console.ForegroundColor = ConsoleColor.Blue;
				    Console.WriteLine("You picked blue. Now pick: sea or mountain?");
					blueAnswer = Console.ReadLine();
					if(blueAnswer == "sea")
					{
						Console.WriteLine("Your next travel should be Alicante.");
					}
					else if (blueAnswer == "mountain")
					{
						Console.WriteLine("Your next destination should be Zermatt,Switzerland");
					}
					else
					{
						Console.WriteLine("Invalid answer;");
					}
					Console.ResetColor();
					break;
					
				}
				default:
				Console.WriteLine("You did not type the correct colour.Please, Try again");
				Console.ResetColor();
				break;
				
				
			}
			Console.ResetColor();
        }
		
    }
}
