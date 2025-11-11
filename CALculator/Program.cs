namespace ProjectCAL
{
    internal class Program
    {
        static void Main()
        {
            while (true)
            {
                Console.WriteLine("Введите первое число: ");
                string input1 = Console.ReadLine();
                double a;

                bool success = double.TryParse(input1, out a);
                if (!success)
                {
                    Console.WriteLine("format ne tot");
                    continue;
                }

                Console.WriteLine("Введите второе число: ");
                string input2 = Console.ReadLine();
                double b;

                bool success2 = double.TryParse(input2, out b);
                if (!success2)
                {
                    Console.WriteLine("format ne tot");
                    continue;
                }

                Console.WriteLine("Выберите действие:");
                Console.WriteLine("'+' - сложение");
                Console.WriteLine("'-' - вычитание");
                Console.WriteLine("'*' - умножение");
                Console.WriteLine("'/' - деление");
                Console.WriteLine("'^' - возведение в степень");

                string choice = Console.ReadLine();
                double result = 0;
                bool Error = false;


                switch (choice)
                {
                    case "+":
                        result = a + b;
                        break;

                    case "-":
                        result = a - b;
                        break;

                    case "*":
                        result = a * b;
                        break;

                    case "/":
                        if (b == 0)
                        {
                            Console.WriteLine("На ноль нельзя");
                            Error = true;
                        }
                        else
                        {
                            result = a / b;
                        }
                        break;

                    case "^":
                        result = Math.Pow(a, b);
                        break;

                    default:
                        Console.WriteLine("недопустимый ввод");
                        Error = true;
                        break;
                }

                if (!Error)
                {
                    Console.WriteLine(result);
                    break;
                }
            }
        }
    }
}


