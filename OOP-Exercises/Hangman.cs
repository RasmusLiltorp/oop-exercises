public class Hangman
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Hangman! Input secret word");

        string hangmanWord = Console.ReadLine();
        char[] guessedChars = new char[hangmanWord.Length];

        int livesLeft = 5;
        bool isPlaying = true;
        Console.WriteLine("Input a single letter");
        Console.WriteLine("Word length: " + hangmanWord.Length);
        
        Console.Clear();

        while (isPlaying)
        {
            Console.WriteLine("Guess the secret word. You have " + livesLeft + " lives left.");  
            string currentGuess = receiveGuess();
            
            if (hangmanWord.Contains(currentGuess))
            {
                // Add currentGuess to guessedChars array
                for (int i = 0; i < hangmanWord.Length; i++)
                {
                    if (hangmanWord[i] == currentGuess[0])
                    {
                        guessedChars[i] = currentGuess[0];
                    }
                }
                Console.WriteLine("Correct guess! Current progress: " + new string(guessedChars));
            }
            else
            {
                Console.WriteLine("Incorrect guess.");
                livesLeft--;
            }

            if (new string(guessedChars) == hangmanWord)
            {
                Console.WriteLine("You win the game!");
                isPlaying = false;
            }

            if (livesLeft <= 0)
            {
                Console.WriteLine("You lose the game!");
                Console.WriteLine("The answer was: " + hangmanWord);
                isPlaying = false;
            }
        }
    }

    public static string receiveGuess()
    {
        string guess;
        do
        {
            guess = Console.ReadLine();
            if (guess.Length != 1)
            {
                Console.WriteLine("Input must be a single character.");
            }
        } while (guess.Length != 1);

        return guess;
    }
}
