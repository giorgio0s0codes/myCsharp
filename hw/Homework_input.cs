using System;
using System.Runtime.Intrinsics.X86;

namespace Homework_input
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Read name, surname, age, weight (in kg) and height (in cm) from console.
            Print a message to the screen based on the information given in 1. (an example message is shown below):

            Tom Jefferson is 19 years old, his weight is 50 kg and his height is 156.5 cm. 

            Calculate and print body-mass index (BMI)
            Do 1 and 2 for another person.
            */
            double weight;
            double height;
            double BMI;

            (weight, height) = ReceiveData();
            BMI = CalculateBMI(weight, height);
            Console.WriteLine($"His BMI is {BMI:F1}");
            
        }

        static (double weight, double height) ReceiveData()
        {
            string name;
            string surname;
            int age;
            double weight;
            double height;

            Console.WriteLine("Please introduce your Name: ");
            name = Console.ReadLine()?? "0";

            Console.WriteLine("Please introduce your Surname: ");
            surname = Console.ReadLine()?? "0";

            Console.WriteLine("Please introduce your age: ");
            age = int.Parse(Console.ReadLine()?? "0");

            Console.WriteLine("Please introduce your Weight in kg: ");
            weight = double.Parse(Console.ReadLine()?? "0");

            Console.WriteLine("Please introduce your height in cm: ");
            height = double.Parse(Console.ReadLine()?? "0");

            Console.WriteLine($"{name} {surname} is {age} years old, his weight is {weight}kg and his height is {height}cm");

            return (weight, height);

        }

        static double CalculateBMI(double weight, double height)
        {
            double calculation;

            calculation = (weight / (height*height))*10000;

            return calculation;
        }
    
    }
}