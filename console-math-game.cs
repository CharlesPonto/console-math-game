using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int health = 5;
            int correctAnswer;
            int answerInput;
            int attemp = 0;

            Console.WriteLine("Enter first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
           
            correctAnswer = num1 * num2;
            Console.WriteLine($"\nWhat's the value of {num1} x {num2}? ");
            

            while(health > 0)
            {
                Console.Write("\nEnter your answer: ");
                answerInput = Convert.ToInt32(Console.ReadLine());

                if(answerInput != correctAnswer)
                {
                    Console.WriteLine("Close but it was wrong!");
                    Console.WriteLine($"Remaining health: {--health}");
                    attemp++;

                    if(health == 0) Console.WriteLine("You lose, try again next time!");
                }
                else
                {
                    Console.WriteLine("Congrats, you won!");
                    Console.WriteLine($"Total attempts: {attemp}");
                    break;
                }
            }
        }
    }
}