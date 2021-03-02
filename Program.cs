using System;

int secretNumber = new Random().Next(1, 100);
Console.WriteLine(secretNumber);

//we will display a message to the user asking them to guess the secret number
string SecretQuestion = "Guess the secret number";

int numOfTriesForEasyLevel = 0;
int numOfTriesForMediumLevel = 0;
int numOfTriesForDifficultLevel = 0;
int currentGuess = 1;
int guessesForDifficultLevel = 4;
int guessesForMediumLevel = 6;
int guessesForEasyLevel = 8;

string questionOfDifficultyLevel = "How hard do you want this game to be?";
Console.WriteLine($"{questionOfDifficultyLevel} Easy/Medium/Hard: ");
string userDifficultyLevelAnswer = Console.ReadLine().ToLower();

if (userDifficultyLevelAnswer == "easy")
{
    while (numOfTriesForEasyLevel < guessesForEasyLevel)
    {
        Console.Write($"{SecretQuestion}: ");
        //we will save the user's guess as input and save it as a variable
        string answer = Console.ReadLine();
        int parsedAnswer = Int32.Parse(answer);
        //if the user's answer is not same as our secret number
        if (parsedAnswer != secretNumber)
        {
            //print out this mssage
            Console.WriteLine($"You guessed wrong!! Muahahaha, maybe next time pal.");

            if (parsedAnswer > secretNumber)
            {
                Console.WriteLine("But your guess is too high. Try to go lower.");
            }
            else
            {
                Console.WriteLine("But your guess is too low. Try to go up.");
            }
        }
        else //otherwise
        {
            //tell them this
            Console.WriteLine("Oo, you're a good one. Great job! You guessed it right!");
            break;
        }
        guessesForEasyLevel--;

        Console.WriteLine($"Your guess ({currentGuess})");
        Console.WriteLine($"You have {guessesForEasyLevel} guesses left but no pressure.");
        currentGuess++;

    }
}

else if (userDifficultyLevelAnswer == "medium")
{
    while (numOfTriesForMediumLevel < guessesForMediumLevel)
    {
        Console.Write($"{SecretQuestion}: ");
        //we will save the user's guess as input and save it as a variable
        string answer = Console.ReadLine();
        int parsedAnswer = Int32.Parse(answer);
        //if the user's answer is not same as our secret number
        if (parsedAnswer != secretNumber)
        {
            //print out this mssage
            Console.WriteLine($"You guessed wrong!! Muahahaha, maybe next time pal.");

            if (parsedAnswer > secretNumber)
            {
                Console.WriteLine("But your guess is too high. Try to go lower.");
            }
            else
            {
                Console.WriteLine("But your guess is too low. Try to go up.");
            }
        }
        else //otherwise
        {
            //tell them this
            Console.WriteLine("Oo, you're a good one. Great job! You guessed it right!");
            break;
        }
        guessesForMediumLevel--;

        Console.WriteLine($"Your guess ({currentGuess})");
        Console.WriteLine($"You have {guessesForMediumLevel} guesses left but no pressure.");
        currentGuess++;

    }
}

else if (userDifficultyLevelAnswer == "hard")
{
    while (numOfTriesForDifficultLevel < guessesForDifficultLevel)
    {
        Console.Write($"{SecretQuestion}: ");
        //we will save the user's guess as input and save it as a variable
        string answer = Console.ReadLine();
        int parsedAnswer = Int32.Parse(answer);
        //if the user's answer is not same as our secret number
        if (parsedAnswer != secretNumber)
        {
            //print out this mssage
            Console.WriteLine($"You guessed wrong!! Muahahaha, maybe next time pal.");

            if (parsedAnswer > secretNumber)
            {
                Console.WriteLine("But your guess is too high. Try to go lower.");
            }
            else
            {
                Console.WriteLine("But your guess is too low. Try to go up.");
            }
        }
        else //otherwise
        {
            //tell them this
            Console.WriteLine("Oo, you're a good one. Great job! You guessed it right!");
            break;
        }
        guessesForDifficultLevel--;

        Console.WriteLine($"Your guess ({currentGuess})");
        Console.WriteLine($"You have {guessesForDifficultLevel} guesses left but no pressure.");
        currentGuess++;

    }
}
