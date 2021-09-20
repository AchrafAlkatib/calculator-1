using System;
using System.Collections.Generic;
using System.Text;

namespace calculator_1
{
    class Calculator
    {
        public void Update()
        {
            Calc calc = new Calc();
            
        

            bool finished = false;


            while (!finished)
            {
                Console.WriteLine("Enter the operator (+ - / *)");
                string op = Console.ReadLine();

                Console.WriteLine("Enter your first number");
                float num1 = Convert.ToInt32(Console.ReadLine());


                Console.WriteLine("Enter your second number");
                float num2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Do you wanna add more number(Y / N)");

                bool array = false;
                string input = Console.ReadLine().ToUpper();
                List<float> arrays = new List<float>();
                if (input == "Y")
                {
                    array = true;
                    arrays.Add(num1);
                    arrays.Add(num2);

                    while (array)
                    {
                        Console.WriteLine("Enter your  number");
                        float num = Convert.ToInt32(Console.ReadLine());

                        arrays.Add(num);
                        Console.WriteLine("Do you wanna add more number(Y / N)");
                                                
                       input = Console.ReadLine().ToUpper();
                        if (input == "N")
                        {
                            array = false;
                        }
                    }
                   
                }

                string result = "";
                switch (op)
                {
                    case "+":
                        if (arrays.Count > 0) result = calc.Add(arrays).ToString();
                        else result = calc.Add(num1, num2).ToString();
                        break;
                    case "-":
                        if (arrays.Count > 0) result = calc.Subtract(arrays).ToString();
                        else result = calc.Subtract(num1, num2).ToString();
                        break;
                    case "/":
                        
                            result = calc.Divide(num1, num2).ToString();

                        if (result == "NaN")
                            Console.WriteLine("You can't divide by zero");
                            
                        
                         
                           break;
                    case "*":
                        result = calc.Multiply(num1, num2).ToString();
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
                    input = Console.ReadLine().ToUpper();

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
