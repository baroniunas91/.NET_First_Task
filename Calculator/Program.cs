using System;
using System.Collections.Generic;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculator");
            Console.WriteLine("To close application write - stop");
            string combination = Console.ReadLine();
            string operation = "";

            while (combination != "stop")
            {
                for (int i = 0; i < combination.Length; i++)
                {
                    if (combination[i] == '+')
                    {
                        operation = "+";
                    }
                    else if (combination[i] == '*')
                    {
                        operation = "*";
                    }
                    else if (combination[i] == '-')
                    {
                        operation = "-";
                    }
                    else if (combination[i] == '/')
                    {
                        operation = "/";
                    }
                }
                bool fail = false;
                string[] numbers = combination.Split(operation);
                for (int i = 0; i < numbers.Length; i++)
                {
                    if(numbers[i].Contains(".")) {
                        fail = true;
                        //numbers[i].Replace('.', ',');
                    }
                }
                if(fail)
                {
                    Console.WriteLine("Nevalidu");
                    combination = Console.ReadLine();
                    continue;
                }
                List<double> numbersList = new List<double>();
                foreach (var item in numbers)
                {
                    if (item != "")
                    {
                        double num = double.Parse(item.ToString());
                        numbersList.Add(num);
                    }

                }
                double result = 0;
                for (int i = 0; i < numbersList.Count; i++)
                {
                    if (operation == "+")
                    {
                        if (i == 0)
                        {
                            result = Convert.ToDouble(numbersList[i]);

                        }
                        else
                        {
                            result += Convert.ToDouble(numbersList[i]);
                        }
                    }
                    else if (operation == "-")
                    {
                        if (i == 0)
                        {
                            result = Convert.ToDouble(numbersList[i]);
                        }
                        else
                        {
                            result -= Convert.ToDouble(numbersList[i]);
                        }
                    }
                    else if (operation == "*")
                    {
                        if (i == 0)
                        {
                            result = Convert.ToDouble(numbersList[i]);
                        }
                        else
                        {
                            result *= Convert.ToDouble(numbersList[i]);
                        }
                    }
                    else if (operation == "/")
                    {
                        if (i == 0)
                        {
                            result = Convert.ToDouble(numbersList[i]);
                        }
                        else
                        {
                            result /= Convert.ToDouble(numbersList[i]);
                        }
                    }
                }
                Console.WriteLine($"Result: {result}");
                combination = Console.ReadLine();
            }
        }
    }
}
