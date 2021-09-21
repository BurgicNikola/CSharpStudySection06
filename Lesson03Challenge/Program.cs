using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson03Challenge
{
    /*Create an application that takes 2 input values.
     * Any input value (1st input)
     * Asks the data type of the input value. (2nd input)
     * It will print to the console the options like below to take input for the 2nd input value:
     * Press 1 for String
     * Press 2 for integer
     * Press 3 for Boolean
     * If the input value for the 2nd input is 1 then the application should check that if the entered 
     * 1st input is a valid string or not. Hereby we even want to check, if it is a complete alphabetic 
     * entry (so no numbers accepted)
     * If the input value for the 2nd input is 2 then the application should check if the entered 1st 
     * input is a valid integer or not.
     * Based on the input the 1st value and the selection of data type using the 2nd input, the application 
     * should return whether the entered 1st value is of data type selected by the user or not.
     * Please make sure to use a switch statement. To check the valid string you can write your custom logic.
     * For example:
     * Enter a value: {here you can enter any value}
     * Select the Data type to validate the input you have entered.
     * Press 1 for String
     * Press 2 for Integer
     * Press 3 for Boolean
     * Here, if you enter 1 it should return below message
     * You have entered a value: Denis Panjuta
     * It is a valid: String
     * Here, if you enter 2 it should return below message
     * You have entered a value: Denis Panjuta
     * It is an invalid: Integer*/
    class Program
    {
        static void Main(string[] args)
        {
            int intFirstInput;
            int dataType = 0;
            int pickedOption;
            string firstInput;
            bool firstInputIsInt;
            bool firstInputContainsInt;
            bool firstInputIsBool;

            Console.WriteLine("Enter a string, integer or boolean:");
            firstInput = Console.ReadLine().Trim();
            firstInputIsBool = CheckIfBoolean(firstInput);
            firstInputIsInt = CheckIfInputIsInt(firstInput);
            firstInputContainsInt = CheckIfInputContainsInt(firstInput);
            // First check if user entered a bool value. Then check if parsing to int was successful and the input is integer.
            // Then, if input is not an int, not a bool, does not contain digits, it means it is a string.
            if (firstInputIsBool)
            {
                // Option 3 is boolean.
                dataType = 3;
            }
            else if(firstInputIsInt)
            {
                // Option 2 is integer.
                dataType = 2;
            }
            else if(!firstInputContainsInt)
            {
                // Option 1 is string.
                dataType = 1;
            }

            Console.WriteLine("What is it's value type?" +
                "\n1. String" +
                "\n2. Integer" +
                "\n3. Boolean" +
                "\nPlease chose from 1 to 3 and press enter.");
            string secondInput = Console.ReadLine();
            bool secondInputIsInt = int.TryParse(secondInput, out pickedOption);
            if(secondInputIsInt)
            {
                switch(pickedOption)
                {
                    case 1:
                        Console.WriteLine("You have chosen string as a value type." +
                            "\nThe value you entered is \"" + firstInput + "\"");
                        if (dataType == 1)
                        {
                            Correct();
                        }
                        else
                        {
                            Incorrect();
                        }
                        break;
                    case 2:
                        Console.WriteLine("You have chosen integer value type." +
                            "\nThe value you entered is \""+ firstInput + "\"");
                        if (dataType == 2)
                        {
                            Correct();
                        }
                        else
                        {
                            Incorrect();
                        }
                        break;
                    case 3:
                        Console.WriteLine("You have chosen boolean value type." +
                            "\nThe value you entered is \"" + firstInput + "\"");
                        if (dataType == 3)
                        {
                            Correct();
                        }
                        else
                        {
                            Incorrect();
                        }
                        break;
                    default:
                        Console.WriteLine("Not an option. Restart and try again.");
                        break;
                }
            }
            // In case user enters anything that is not 1, 2 or 3
            else
            {
                Console.WriteLine("Restart program and try again");
            }
            Console.ReadLine();
        }

        private static bool CheckIfBoolean(string firstInput)
        {
            if(firstInput == "True" || firstInput == "true" || firstInput == "False" || firstInput == "false")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static bool CheckIfInputContainsInt(string firstInput)
        {
            bool firstInputContainsInt = firstInput.Any(char.IsDigit);
            return firstInputContainsInt;
        }

        private static bool CheckIfInputIsInt(string firstInput)
        {
            int i;
            bool firstInputIsInt = int.TryParse(firstInput, out i);
            return firstInputIsInt;
        }

        private static void Correct()
        {
            Console.WriteLine("You have chosen the correct value type.");
        }

        private static void Incorrect()
        {
            Console.WriteLine("You have chosen an incorrect value type.");
        }
    }
}
