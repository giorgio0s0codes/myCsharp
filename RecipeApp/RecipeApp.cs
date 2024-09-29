//Import classes from System Namespace
using System;
using System.Diagnostics;

//Holder of Classes
namespace RecipeApp
{
    /*
    Here is a list of standard cooking units:
    Cup 	0.24 l
    Gallon 	3.79 l
    Fluid Ounce 	29.57 ml
    Pint 	0.47 l
    Quart 	0.95 l
    Tablespoon 	14.79 ml
    Teaspoon 	4.93 ml
    */

//Holder of Functions and Data
    class Program
    {
        //Named Block of Code
        static void Main(string[] args)
        {
            double tbMl;
            double tsMl;
            double totalMl;

            /*cookingUnitAmount = GetAmountFromConsole(unit:"teaspoons");
            ml = TeaspoonsToMl(cookingUnitAmount);
            ml =TablespoonsToMl(cookingUnitAmount);
            Print(cookingUnitAmount, "teaspoons", ml);*/

            tsMl = CalculateTeaspoonsToMl();
            tbMl = CalculateTablespoonsToMl();
            totalMl = tbMl + tsMl;

            PrintHowMany100MlBottles(totalMl);

        }

        static double CalculateTablespoonsToMl()
        {
            double cookingUnitAmount;
            double ml;

            cookingUnitAmount = GetAmountFromConsole(unit:"tablespoons");
            ml = TablespoonsToMl(cookingUnitAmount);
            Print(cookingUnitAmount, "tablespoons", ml);
            return ml;
        }

        static double CalculateTeaspoonsToMl()
        {
            double cookingUnitAmount;
            double ml;

            cookingUnitAmount = GetAmountFromConsole(unit:"teaspoons");
            ml = TeaspoonsToMl(cookingUnitAmount);
            Print(cookingUnitAmount, "teaspoons", ml);
            return ml;
            
        }

        static double GetAmountFromConsole(string unit)
        {
            //Variable
            //type  name  =  value
            //double, is a "floating point number", this is used for arithmetics.
            //decimal, is used when you need absolute precision (money).
            //float, when you don't plan to use actual math. 

            string amountText;
            double cookingUnitAmount;

            Console.WriteLine($"Please enter {unit} amount: ");
            amountText = Console.ReadLine() ?? "0";
            cookingUnitAmount = double.Parse(amountText);
            return cookingUnitAmount;
        }

        static double TeaspoonsToMl(double cookingUnitAmount)
        {
            double ml;

            ml = cookingUnitAmount * 4.93;

            return ml;
        }

        static double TablespoonsToMl(double cookingUnitAmount)
        {
            double ml;

            ml = cookingUnitAmount * 14.79;

            return ml;
        }

        static void Print(double cookingUnitAmount, string cookingUnit ,double ml)
        {
            //Console.WriteLine(input + " teaspoons are " + mlAmount + " mL");
            // string convertedDescription = teaspoonsText + " teaspoons = " + ml + " ml";
            // $- string interpolation
            // F2- 2 digits after decimal point.

            string convertedDescription = $"{cookingUnitAmount} {cookingUnit} = {ml:F2} ml";
            Console.WriteLine(convertedDescription);

            return;
        }

        static void PrintHowMany100MlBottles(double ml)
        {
            int bottles;

            bottles = (int)(ml / 100) + 1;   

            Console.WriteLine($"{ml:F2}ml can fill {bottles} bottles of 100ml");
        }
    }
}