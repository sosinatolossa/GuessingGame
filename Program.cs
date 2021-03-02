using System;
//our secret number will be generated randomly between the range of 1 and 100
int secretNumber = new Random().Next(1, 100);
//Console.WriteLine(secretNumber);

//we will display a message to the user asking them to guess the secret number
string SecretQuestion = "Guess the secret number";

int numOfTries = 0; //initialize the number of tries 0
int currentGuess = 1; //initialize number of guesses 1
int guessesForDifficultLevel = 4; //give 4 chances for guessing for high dificulty level
int guessesForMediumLevel = 6; //give 6 chances for guessing for midium dificulty level
int guessesForEasyLevel = 8; //give 8 chances for guessing for easy level

//create a question and store that in a variable
string questionOfDifficultyLevel = "How hard do you want this game to be?";
//ask them the above question and the level of dificulty they want this game to be/if they want to cheat
Console.WriteLine($"{questionOfDifficultyLevel} Easy/Medium/Hard/Cheater: ");
//change their input to lower case
string userDifficultyLevelAnswer = Console.ReadLine().ToLower();

//if the user wants this game to be easy
if (userDifficultyLevelAnswer == "easy")
{
    //while numOfTries is less than guessesForEasyLevel(currently 8), keep...
    while (numOfTries < guessesForEasyLevel)
    {
        //asking them the question
        Console.Write($"{SecretQuestion}: ");
        //we will save the user's guess as input and save it as a variable
        string answer = Console.ReadLine();
        //we will change the answer(which is a string number) to number
        int parsedAnswer = Int32.Parse(answer);
        //if the user's answer is not same as our secret number/gueesed wrong
        if (parsedAnswer != secretNumber)
        {
            //print out this mssage
            Console.WriteLine($"You guessed wrong!! Muahahaha, maybe next time pal.");

            //if the answer the user gave is greater than our sectret number
            if (parsedAnswer > secretNumber)
            {
                //tell them this
                Console.WriteLine("But your guess is too high. Try to go lower.");
            }
            else //if it is less than our secret number
            {
                //tell them this
                Console.WriteLine("But your guess is too low. Try to go up.");
            }
        }
        else //if the user guessed our secret question correctly
        {
            //tell them this
            Console.WriteLine("Oo, you're a good one. Great job! You guessed it right!");
            break; //and quit asking them the question!
        }
        //decrement the guessesForEasyLevel by 1
        guessesForEasyLevel--;
        //tell them how many times they've guessed so far
        Console.WriteLine($"You've guessed ({currentGuess}) time/times so far.");
        //tell them how many guesses they've left
        Console.WriteLine($"You have {guessesForEasyLevel} guesses left but no pressure.");
        //increment the currentGuess by 1
        currentGuess++;

    }
}

//if the user wants this game to be medium level difficult
else if (userDifficultyLevelAnswer == "medium")
{
    //while numOfTries is less than guessesForMediumLevel(currently 6), keep...
    while (numOfTries < guessesForMediumLevel)
    {
        //asking them the question
        Console.Write($"{SecretQuestion}: ");
        //we will save the user's guess as input and save it as a variable
        string answer = Console.ReadLine();
        int parsedAnswer = Int32.Parse(answer); //change it to integer
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
        else //if the user guessed our secret question correctly
        {
            //tell them this
            Console.WriteLine("Oo, you're a good one. Great job! You guessed it right!");
            break;
        }
        //decrement the guessesForMediumLevel by 1
        guessesForMediumLevel--;

        Console.WriteLine($"You've guessed ({currentGuess}) time/times so far.");
        Console.WriteLine($"You have {guessesForMediumLevel} guesses left but no pressure.");
        currentGuess++;

    }
}

//if the user wants this game to be hard
else if (userDifficultyLevelAnswer == "hard")
{
    //while numOfTries is less than guessesForDifficultLevel(currently 4), keep...
    while (numOfTries < guessesForDifficultLevel)
    {
        //asking them the question
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
        else //if the user guessed our secret question correctly
        {
            //tell them this
            Console.WriteLine("Oo, you're a good one. Great job! You guessed it right!");
            break;
        }
        //decrement the guessesForDifficultLevel by 1
        guessesForDifficultLevel--;

        Console.WriteLine($"You've guessed ({currentGuess}) time/times so far.");
        Console.WriteLine($"You have {guessesForDifficultLevel} guesses left but no pressure.");
        currentGuess++;

    }
}

//if the user wants to cheat on this game
else if (userDifficultyLevelAnswer == "cheater")
{
    //we will give them maximum number of tries that csharp allows
    while (numOfTries < Int32.MaxValue)
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
        else ////if the user guessed our secret question correctly
        {
            //tell them this
            Console.WriteLine("Oo, you're a good one. Great job! You guessed it right!");
            break; //break this dang loop of asking the question
        }

        //tell them how many times they've guessed so far
        Console.WriteLine($"You've guessed ({currentGuess}) time/times so far.");
        currentGuess++;
    }

}