using System;
using System.Collections.Generic;
using System.Linq;

namespace oop_lesson5_eightball
{
    class Program
    {
        static void Main(string[] args)
        {
            int randomNumber;
            Random number = new();
            randomNumber = number.Next(20);

            List<string> possibleAnswers = new();
            possibleAnswers.Insert(0, "It is certain.");
            possibleAnswers.Insert(1, "It is decidedly so.");
            possibleAnswers.Insert(2, "Without a doubt.");
            possibleAnswers.Insert(3, "Yes definitely.");
            possibleAnswers.Insert(4, "You may rely on it.");
            possibleAnswers.Insert(5, "As i see it, yes.");
            possibleAnswers.Insert(6, "Most likely.");
            possibleAnswers.Insert(7, "Outlook good.");
            possibleAnswers.Insert(8, "Yes.");
            possibleAnswers.Insert(9, "Signs point to yes.");
            possibleAnswers.Insert(10, "Reply hazy, try again.");
            possibleAnswers.Insert(11, "Ask again later.");
            possibleAnswers.Insert(12, "Better not tell you now.");
            possibleAnswers.Insert(13, "Cannot predict now.");
            possibleAnswers.Insert(14, "Concentrate and ask again.");
            possibleAnswers.Insert(15, "Don't count on it.");
            possibleAnswers.Insert(16, "My reply is no.");
            possibleAnswers.Insert(17, "My sources say no.");
            possibleAnswers.Insert(18, "Outlook not so good.");
            possibleAnswers.Insert(19, "Very doubtful.");

            var answer = possibleAnswers.ElementAt(randomNumber);

            Console.WriteLine("Please, make a question of Yes or No: ");
            var question = Console.ReadLine();
            Console.WriteLine($"Your answer: {answer}");


        }
    }
}
