public class Hangman
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Hangman! Input secret word");

        string hangmanWord = Console.ReadLine();
        char[] gussedChars = new char[hangmanWord.Length];

        int livesLeft = 5;
        bool isPlaying = true;
        Console.WriteLine("Input a single letter");
        Console.WriteLine("Word length: " + hangmanWord.Length);
        
        Console.Clear();

        while (isPlaying)
        {
            Console.WriteLine("Guess a secret word. You have " + livesLeft + " lives left.");  
            string currentGuess = receiveGuess();
            
            if (hangmanWord.Contains(currentGuess))
            {
                // add currentGuess to guessedChars array
                for (int i = 0; i < hangmanWord.Length; i++)
                {
                    if (hangmanWord[i] == currentGuess[0])
                    {
                        gussedChars[i] = currentGuess[0];
                    }
                }
                Console.WriteLine("Correct guess! Current progress: " + new string(gussedChars));
            }
            else
            {
                Console.WriteLine("Incorrect guess.");
                
                livesLeft--;
            }
            if (new string(gussedChars) == hangmanWord)
            {
                Console.WriteLine("You win the game!");
                isPlaying = false;
            }

            if (livesLeft <= 0)
            {
                Console.WriteLine("You lose the game!");
                Console.WriteLine("Answer was:" + new string(hangmanWord));
                isPlaying = false;
            }

        }
    }
    public static string receiveGuess()
    {
        bool guessing = true;
        string guess = Console.ReadLine();     
        while (guessing)
        {
            if (guess.Length > 1)                                                   
            {                                                                       
                Console.WriteLine("Length must be just one character at a time.");
                guessing = false;
            }                                                                       
            else if (guess.Length == 1)
            {
                guessing = false;
            }
        }
        return guess;     
    }
}