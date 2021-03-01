using System;

string secretNumber = "72";

//we will display a message to the user asking them to guess the secret number
string SecretQuestion = "Guess the secret number";
Console.Write($"{SecretQuestion}: ");
//we will save the user's guess as input and save it as a variable
string answer = Console.ReadLine();

if (answer != secretNumber) 
{
    Console.Write($"You guessed wrong!! Muahahaha, maybe next time pal.");
}
else
{
    Console.Write("Oo, you're a good one. Great job! You guessed it right!");
}