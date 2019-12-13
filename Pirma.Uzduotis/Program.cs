using Pirma.Uzduotis.Controller;
using Pirma.Uzduotis.Interface;
using System;

namespace Pirma.Uzduotis
{
    class Program
    {
        private static ICalculator _calculator;

        static void Main(string[] args)
        {
            //Initialize Calculator
            _calculator = new Calculator();

            //Creates input collector object
            InputCollector inputCollector = new InputCollector();

            //Gets hours value from input collector class
            int hours = inputCollector.GetEnteredValue(Constants.Messages.Hours);

            //Gets minutes value from input collector class
            int minutes = inputCollector.GetEnteredValue(Constants.Messages.Minutes);

            Console.WriteLine("The smaller angle between {0} hours and {1} minutes is {2}", hours, minutes, _calculator.CalculateAngle(hours, minutes));

            Console.WriteLine("Press any key to close the application..");

            Console.ReadKey();
        }
    }
}
