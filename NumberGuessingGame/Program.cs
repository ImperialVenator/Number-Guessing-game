// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welcome to the number guessing game!");
bool keeploop = true;
while (keeploop)
{
    Random random = new Random();
    int numberToGuess = random.Next(1, 101);
    bool guessedCorrectly = false;
    int guessCount = 0;
    while (guessedCorrectly == false)
    {
        Console.WriteLine("Can you guess the number between 1 and 100?");
        int guess = int.Parse(Console.ReadLine()!);
        guessCount++;
        if (guess < numberToGuess)
        {
            Console.WriteLine("Too low! Try again:");
        }
        else if (guess > numberToGuess)
        {
            Console.WriteLine("Too high! Try again:"); 
        }
        else
        {
            Console.WriteLine("You got it! You've guessed the number!");
            guessedCorrectly = true;
            Console.WriteLine($"It took you {guessCount} guesses to find the number.");    
        }
    }
    Console.WriteLine("Do you want to play again? (y/n)");
    string playAgain = Console.ReadLine()!;
    if (playAgain.ToLower() != "yes" && playAgain.ToLower() != "y")
    {
        keeploop = false;
    }
}



