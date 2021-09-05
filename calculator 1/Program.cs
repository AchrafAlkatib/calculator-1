using System;

namespace calculator_1
{
    class Program
    {

        static float Add(float x, float y) { return x + y; }
        static float Subtract(float x, float y) { return x - y; }
        static float Divide(float x, float y) { return x / y; }
        static float Multiply(float x, float y) { return x * y; }

        static void Main(string[] args)
        {
            bool finished = false;

            while (!finished)
            {
                Console.WriteLine("Enter your first number");
                float num1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the operator (+ - / *)");
                string op = Console.ReadLine();

                Console.WriteLine("Enter your second number");
                float num2 = Convert.ToInt32(Console.ReadLine());

                string result = "";
                switch (op)
                {
                    case "+":
                        result = Add(num1, num2).ToString();
                        break;
                    case "-":
                        result = Subtract(num1, num2).ToString();
                        break;
                    case "/":
                        if (num1 != 0 && num2 != 0)
                            result = Divide(num1, num2).ToString();
                        else result = "INVALID";
                        break;
                    case "*":
                        result = Multiply(num1, num2).ToString();
                        break;
                    default:
                        result = "Invalid operation";
                        break;
                }
                Console.WriteLine("Your number is: " + result);
                Console.WriteLine("\n");

                bool keepAlive = true;

                while (keepAlive)
                {

                    Console.WriteLine("Continue? (Y / N)");
                    string input = Console.ReadLine().ToUpper();

                    if (input == "Y")
                    {
                        Console.WriteLine("Program will continue");
                        keepAlive = false;
                    }
                    else if (input == "N")
                    {
                        finished = true;
                        Console.WriteLine("Exiting");
                        keepAlive = false;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input \n");
                    }
                }
             
            }
        }
    }
}