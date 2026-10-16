using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("                     Калькулятор\nЗнаки: +, -, *, /");
            double number_1 = ReadNumber("Введите первое число: ");
            double number_2 = ReadNumber("Введите второе число: ");
            char operation = ReadOperation();
            //Ошибка в случае деления на ноль
            if (operation == '/' && number_2 == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Ошибка!Деление на 0 невозможно\nНажмите любую клавишу чтобы начать заново или E для выхода...");
                Console.ResetColor();
                Exit();
                continue;
            }

            //Ошибка в случае ввода неверного символа
            if (operation != '+' && operation != '-' && operation != '*' && operation != '/')
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write($"Ошибка!Знак {operation} не соотвествует\nНажмите любую клавишу чтобы начать заново или E для выхода...");
                Console.ResetColor();
                Exit();
                continue;

            }

            //Выводим результат
            double result = Calculate(number_1, number_2, operation);
            Console.WriteLine($"\nРезультат: {number_1} {operation} {number_2} = {result}\nНажмите любую клавишу чтобы начать заново или E для выхода...");
            Exit();

            ////Выход из программы 
            void Exit()
            {
                ConsoleKeyInfo exit = Console.ReadKey(true);
                if (exit.Key == ConsoleKey.E) Environment.Exit(0);
            }



            static double ReadNumber(string message)
            {
                Console.Write(message);
                return Convert.ToDouble(Console.ReadLine());
            }
            //Считываем знак
            static char ReadOperation()
            {
                Console.Write("Введите знак: ");
                return Convert.ToChar(Console.ReadLine());
            }
            //Считаем результат
            static double Calculate(double num1, double num2, char op)
            {

                if (op == '+') return num1 + num2;
                if (op == '-') return num1 - num2;
                if (op == '*') return num1 * num2;
                if (op == '/') return num1 / num2;

                return 0;
            }
        }
    }
}