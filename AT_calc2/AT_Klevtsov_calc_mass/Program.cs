using System;

namespace AT_Klevtsov_calc_mass
{
    class Program
    {
        static void Main(string[] args)
        {
            char again = 'y';
            while (again == 'y')
            {
                double a;
                double b;
                double total;
                char oper;
                double x;

                Console.WriteLine("Введите первое число:");
                if (Double.TryParse(Console.ReadLine(), out x))
                {
                    a = x;
                }
                else
                {
                    Console.WriteLine("Некорректный ввод первого оператора");
                    break;
                }

                Console.WriteLine("Введите оператор:");
                oper = Convert.ToChar(Console.ReadLine());
                Console.WriteLine("Введите второе число:");

                if (Double.TryParse(Console.ReadLine(), out x))
                {
                    b = x;
                }
                else
                {
                    Console.WriteLine("Некорректный ввод второго оператора");
                    break;
                }


                switch (oper)
                {

                    case '+':
                        total = a + b;
                        Console.WriteLine("Cумма " + a + " и " + b + " равна " + total + ".");
                        break;


                    case '-':
                        total = a - b;
                        Console.WriteLine("Разность " + a + " и " + b + " равна " + total + ".");
                        break;

                    case '*':
                        total = a * b;
                        Console.WriteLine("Умножение " + a + " на " + b + " равно " + total + ".");
                        break;

                    case '/':
                        total = a / b;
                        Console.WriteLine("Деление " + a + " на " + b + " равно " + total + ".");
                        break;


                    default:
                        Console.WriteLine("Неизвестный оператор.");
                        break;
                };

                Console.WriteLine("Вы хотите продолжить работу с калькулятором? (y/n)");
                again = Convert.ToChar(Console.ReadLine());
            }
        }
    }
}
