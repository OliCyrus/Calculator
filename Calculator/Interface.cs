using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Interface
    {
        private Calculator calculator;

        public Interface(Calculator calculator)
        {
            this.calculator = calculator;
        }

        public double[] InputNumbers()
        {
            double[] numbersArr = new double[2];
            string str;

            while (true)
            {
                try
                {
                    if (numbersArr[0].Equals(0))
                    {
                        Console.WriteLine("Input a:");
                        str = Console.ReadLine();
                        if (!double.TryParse(str, out numbersArr[0])) throw new Exception();
                    }
                    if (numbersArr[1].Equals(0))
                    {
                        Console.WriteLine("Input b:");
                        str = Console.ReadLine();
                        if(!double.TryParse(str, out numbersArr[1])) throw new Exception();
                    }

                    return numbersArr;
                }
                catch (Exception)
                {
                    Console.WriteLine("Entered value  is not a number. Try again");
                }
            }
        }

        public void StartCalculator()
        {
            string outputString = "";
            int operationCode = 0;
            double[] numbersArr;

            while (true)
            {
                numbersArr = InputNumbers();

                try {
                    
                Console.WriteLine("Choose operation:");
                Console.WriteLine("1. Addition \n2. Subtraction \n3. Division \n4. Multiplication");

                if (!int.TryParse(Console.ReadLine(), out operationCode)) throw new Exception();

                switch (operationCode)
                {
                    case 1:
                        outputString = calculator.Add(numbersArr[0], numbersArr[1]).ToString();
                        break;
                    case 2:
                        outputString = calculator.Sub(numbersArr[0], numbersArr[1]).ToString();
                        break;
                    case 3:
                        outputString = calculator.Div(numbersArr[0], numbersArr[1]).ToString();
                        break;
                    case 4:
                        outputString = calculator.Mul(numbersArr[0], numbersArr[1]).ToString();
                        break;
                    default:
                        outputString = "Wrong operation code.";
                        break;
                }

                Console.WriteLine("Result = " + outputString);
                Console.WriteLine("1. Exit \n2. Try again");
                if (Convert.ToInt32(Console.ReadLine()) == 1)
                    break;

                }
                catch (Exception)
                {
                    Console.WriteLine("Wrong operation code.");
                }
            }
        }
    }
}
