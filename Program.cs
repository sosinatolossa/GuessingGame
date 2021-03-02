using System;

int secretNumber = new Random().Next(1, 100);
//Console.WriteLine(secretNumber);

//we will display a message to the user asking them to guess the secret number
string SecretQuestion = "Guess the secret number";

int num = 0;
int currentGuess = 1;
int guessesLeft = 4;

while (num < 4)
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
    }
    else //otherwise
    {
        //tell them this
        Console.WriteLine("Oo, you're a good one. Great job! You guessed it right!");
        break;
    }
    guessesLeft--;

    Console.WriteLine($"Your guess ({currentGuess})");
    Console.WriteLine($"You have {guessesLeft} guesses left but no pressure.");
    currentGuess++;
    num++;
}