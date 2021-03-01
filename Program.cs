using System;

//we will display a message to the user asking them to guess the secret number
string SecretQuestion = "Guess the secret number";
Console.Write($"{SecretQuestion}: ");
//we will save the user's guess as input and save it as a variable
string answer = Console.ReadLine();
Console.Write(answer);