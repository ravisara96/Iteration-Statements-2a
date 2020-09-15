/*
 
Author: Sachiwa Irugalbandara
Date: 9/15/2020
Comments: This C# console shows the use of Iterative Statements after getting inputs from users.

*/

using System;

namespace Iteration_Statements
{
    class Program
    {
        static void Main(string[] args)
        {
            // Asking from users for an input
            Console.WriteLine("Enter an integer value between 1 and 25 to execute an iterative statement");

           /*
              using try catch block to handle if the user
              enterd a wrong input and a error message will be displayed.
           */
           try
            {
                //This variable will gather data from users input
                string input = Console.ReadLine();
                //This variable will be used to perform the various iterative statements and will parsed as an integer
                int value_of_input = int.Parse(input);
                /*
                    This will use IF/ELSE statements to test the values of user input.
                    It depends on the value of the user input between 1 and 25.
                */
                // If the value of user input is between 1 and 5 it will execute a For Loop
                if ((value_of_input > 0) && (value_of_input <= 5))
                {
                    Console.WriteLine("Execute a For Loop!");
                    Console.WriteLine("The For Loop will iterate " + value_of_input.ToString() + "times."); 
                    // This is the For Loop
                    for (int i = 0; i < value_of_input; i++)
                    {
                        Console.WriteLine("The value of the variable i in this iteration is: " + i.ToString());
                    }
                    Console.WriteLine("Press any key to exit the window....");
                    // Pause the program and wait few seconds to until user press key to end program
                    Console.ReadKey(true);
                }
                // If the value of user input is between 6 and 10 it will execute a For Loop
                if ((value_of_input > 5) && (value_of_input <= 10))
                {
                    Console.WriteLine("Execute a For Loop!");
                    Console.WriteLine("The For Loop will iterate" + value_of_input.ToString() + "times.");
                    // This is the For Loop
                    for (int i = 0; i < value_of_input; i++)
                    {
                        Console.WriteLine("The value of the variable i in this iteration is: " + i.ToString());
                    }
                    Console.WriteLine("Press any key to exit the window....");
                    // Pause the program and wait few seconds to until user press key to end program
                    Console.ReadKey(true);
                }
                // If the value of user input is between 11 and 20it will execute a For Loop
                if ((value_of_input > 10) && (value_of_input <= 20 ))
                {
                    Console.WriteLine("Execute a For Loop!");
                    Console.WriteLine("The For Loop will iterate" + value_of_input.ToString() + "times.");
                    // This is the For Loop
                    for (int i = 0; i < value_of_input; i++)
                    {
                        Console.WriteLine("The value of the variable i in this iteration is: " + i.ToString());
                    }
                    Console.WriteLine("Press any key to exit the window....");
                    // Pause the program and wait few seconds to until user press key to end program
                    Console.ReadKey(true);
                }
                //If the value of user input is between 21 and 25 it will execute a For Loop
                if ((value_of_input > 20) && (value_of_input <=25))
                {
                    Console.WriteLine("Execute a For Loop!");
                    Console.WriteLine("The For Loop will iterate" + value_of_input.ToString() + "times.");
                    // This is the For Loop
                    for (int i = 0; i < value_of_input; i++)
                    {
                        Console.WriteLine("The value of the variable i in this iteration is: " + i.ToString());
                    }
                    Console.WriteLine("Press any key to exit the window....");
                    // Pause the program and wait few seconds to until user press key to end program
                    Console.ReadKey(true);
                }
                // If the user doesn't enter a value between 1 and 25, display this message
                else
                {
                    Console.WriteLine("Please enter an integer between 1 and 25 and try again....");
                    Console.WriteLine("Press any key to exit the program and try again ....");
                    Console.ReadKey(true);
                }
            }// End of try
            catch
            {
                Console.WriteLine("Please enter an integer value and try again....");
                Console.WriteLine("Press any key to exit the program ....");
                Console.ReadKey(true);
             }// End of catch
        }// End of Main
    }//End of Class
}//End of namespace

