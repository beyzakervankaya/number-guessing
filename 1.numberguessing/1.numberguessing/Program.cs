namespace MyProject;
class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        bool playAgain = true;
        int max = 100;
        int min = 1;
        int guess;
        int number;
        int guesses;
        string win = "you win";


        while (playAgain)
        {
            guess = 0;
            guesses = 0;

            number = random.Next(min, max + 1);
            while (guess != number)
            {
                Console.WriteLine("guess the number between " + min + "-" + max);
                guess = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("guess:" + guess);
                if (guess > number)
                {
                    Console.WriteLine(guess + " is so high.");
                }
                else if (guess < number)
                {
                    Console.WriteLine(guess + " is so low.");
                }
                guesses++;
            }
            Console.WriteLine("number: " + number);
            Console.WriteLine(win);
            Console.WriteLine("guesses: " + guesses);
            Console.ReadKey();
            
        }
    }
}

