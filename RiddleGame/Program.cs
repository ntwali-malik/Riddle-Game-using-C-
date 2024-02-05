namespace RiddleGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string[] riddles = {
            "I speak without a mouth and hear without ears. I have no body, but I come alive with the wind. What am I?",
            "The more you take, the more you leave behind. What am I?",
            "What has keys but can't open locks?",
            "What has a head, a tail, is brown, and has no legs?",
            "What has hands but cannot clap?"
        };

            string[] answers = {
            "An echo",
            "Footsteps",
            "A piano",
            "A penny",
            "A clock"
        };

            
            Random rand = new Random();
            int index = rand.Next(0, riddles.Length);

            Console.WriteLine("Here's a riddle for you:");
            Console.WriteLine(riddles[index]);

            Console.Write("Your answer: ");
            string guess = Console.ReadLine();

            if (guess.ToLower() == answers[index].ToLower())
            {
                Console.WriteLine("Congratulations! You've guessed it right!");
            }
            else
            {
                Console.WriteLine("Sorry, that's incorrect. Try again next time!");
            }
        }
    }
}
