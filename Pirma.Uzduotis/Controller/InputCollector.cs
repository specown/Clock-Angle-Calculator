using System;

namespace Pirma.Uzduotis.Controller
{
    public class InputCollector
    {
        public int GetEnteredValue(string valueName)
        {
            bool result = false;
            string userInput;
            int enteredValue, validatedNumber = 0;

            Console.WriteLine("Please enter {0}: ", valueName);

            //Loop until result satisfies conditions
            while (!result)
            {
                //Try parsing into Integer
                if (Int32.TryParse(userInput = Console.ReadLine(), out enteredValue))
                {
                    //Check if range is valid for hours / minutes
                    if (!CheckRange(valueName, enteredValue))
                    {
                        Console.WriteLine("Invalid {0} range, please enter {0} again: ", valueName);
                    }
                    //Range is valid, stop the loop and return the result
                    else
                    {
                        result = true;
                        validatedNumber = enteredValue;
                    }
                }
                //Input is not a number, display an error message
                else
                {
                    Console.WriteLine("{0} is invalid number. Please enter valid integer: ", userInput);
                }
            }

            return validatedNumber;
        }

        private bool CheckRange(string calculatedValue, int enteredValue)
        {
            //Check whether we are validating hours or minutes
            if(calculatedValue == Constants.Messages.Hours)
            {
                //Passing appropiate range to a separate function
                return ValidateRange(0, 12, enteredValue);
            }
            else
            {
                //Validate minute range
                return ValidateRange(0, 60, enteredValue);
            }
        }

        private bool ValidateRange(int minimum, int maximum, int input)
        {
            return (minimum <= input && input <= maximum);
        }
    }
}
