using System;
//create a calculator that can accept two numbers from the user
//user should be able to add, substract, multiply, or divide those two numbers.
//finally the user should be able to choose a color for the text, and be able to choose the color of the backgraound
// and the program should print the full equation of the numbers and the simbols
//for example; if the user puts in the numbers 2 and 3, and decides to add them, then the results will
//look like 2 + 3 = 5
//it will look like 2 / 3 = 0.666
//it will look like 2 * 3 = 6
//it will look like 2 - 3 = -1

namespace Calculator

{
    class Calculator
    {


        static void Main(string[] args)
        {
            bool running = true;
            ConsoleColor DefaultBackGroundColor = Console.BackgroundColor;
            ConsoleColor DefaultForeGroundColor = Console.ForegroundColor;


            while (running)
            {
              

                Calculator.function1();


                string Typing = Console.ReadLine();

                if(Typing == "~")
                {
                    running = false;
                }
                Console.BackgroundColor = DefaultBackGroundColor;
                Console.ForegroundColor = DefaultForeGroundColor;
            }
            
           
            
           

        }
        static void function1()
        {
           
            Console.WriteLine("Welcome to calculator App.");
            Console.WriteLine("Please type two numbers to either add, subtract, divide, or multiply");
            Console.WriteLine("Please type the first Number");
            string userInput = Console.ReadLine();

            float userNumber = float.Parse(userInput);

            Console.WriteLine("Please type the symbol Number");

            string userInput1 = Console.ReadLine();

            Console.WriteLine("Please type the second number");

            string userInput2 = Console.ReadLine();

            float userNumber2 = float.Parse(userInput2);
            ConsoleColor ForeGroundColor = AskForColor("Foreground");
            ConsoleColor BackGoundColor = AskForColor("Background");
            Console.BackgroundColor = BackGoundColor;
            Console.ForegroundColor = ForeGroundColor;

            string result = userNumber + userNumber2 + userInput1;

            float inputNumbers = Calculator.calculateTwoNumbers(userNumber, userNumber2, userInput1);
           
            Console.WriteLine(userNumber + userInput1 + userNumber2 + " =" + " " + inputNumbers);
            Console.WriteLine("Type ~ to quit or type anything else to continue");





        }
        static ConsoleColor AskForColor(string ForeGroundOrBackGound)
        {

            Console.WriteLine("Type a Color for ther text" + ForeGroundOrBackGound);

            string inputColor = Console.ReadLine();

            string inputColorCaps = inputColor.ToUpper();

            if (inputColorCaps == "BLUE")
            {
               return ConsoleColor.Blue;
            }
            else if (inputColorCaps == "GREEN")
            {
                return ConsoleColor.Green;
            }
            else if (inputColorCaps == "YELLOW")
            {
                return ConsoleColor.Yellow;
            }
            if (inputColorCaps == "RED")
            {
                return ConsoleColor.Red;
            }
            if (inputColorCaps == "GRAY")
            {
                return ConsoleColor.Gray;
            }
            if (inputColorCaps == "WHITE")
            {
                return ConsoleColor.White;
            }
            if (inputColorCaps == "BLUE")
            {
              return ConsoleColor.Blue;
            }
            if (inputColorCaps == "MAGENTA")
            {
                return ConsoleColor.Magenta;
            }
            if (inputColorCaps == "DARKGRAY")
            {
                return ConsoleColor.DarkGray;
            }
            if (inputColorCaps == "BLACK")
            {

                return ConsoleColor.Black;
            }
            if (inputColorCaps == "BarkGray")
            {
                return ConsoleColor.DarkGray;
            }
            if (inputColorCaps == "DARKRED")
            {
                return ConsoleColor.DarkRed;
            }
            if (inputColorCaps == "DARKBLUE")
            {
                return ConsoleColor.DarkBlue;
            }
            if (inputColorCaps == "PINK")

            {
                return ConsoleColor.Yellow;
            }
            if (inputColorCaps == "DarkMagenta")
            {
                return ConsoleColor.DarkMagenta;
            }
            if (inputColorCaps == "DarkYellow")
            {
                return ConsoleColor.DarkYellow;
            }
            if (inputColorCaps == "Cyan")
            {
                {
                    return ConsoleColor.Cyan;
                }
            }
            if (inputColorCaps == "DarkCyan")
            {
                return ConsoleColor.DarkCyan;
            }
            return ConsoleColor.Black;
           

        }
        static float calculateTwoNumbers(float leftValue, float rightValue, string symbol)
        {
            if (symbol == "+")
            {
                float sum = leftValue + rightValue;
                return sum;

            }
            else if (symbol == "-")
            {
                float difference = leftValue - rightValue;
                return difference;

            }
            else if (symbol == "*")
            {
                float product = leftValue * rightValue;
                return product;

            }
            else if (symbol == "/")
            {

                float quotient = leftValue / rightValue;
                return quotient;

            }
            else
            {
                return 0;
            }
            
            
           
           

        }
        
    }

}
