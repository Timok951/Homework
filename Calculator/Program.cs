using System.Runtime.InteropServices;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int operation;
            int number1;
            int number2;
            string input;

            do
            {
                Console.WriteLine("1-Сложить два числа 2-вычесть первое из второго 3-перемножить два числа 4-разделить первое на второе 5-возвести в степень N первое число 6-найти квадратный корень из числа 7-найти 1 процент от числа  8-найти факториал из числа 9-выход");
                Console.WriteLine("Выберите операцию:");
                input = Console.ReadLine();
                operation = Convert.ToInt32(input);
                switch (operation) {

                    case 1: Console.WriteLine("Введите первое число"); input = Console.ReadLine(); number1 = Convert.ToInt32(input); Console.WriteLine("Введите второе число"); input = Console.ReadLine(); number2 = Convert.ToInt32(input); Console.WriteLine(number1+number2);
                        break;
                    case 2:
                        Console.WriteLine("Введите первое число"); input = Console.ReadLine(); number1 = Convert.ToInt32(input); Console.WriteLine("Введите второе число"); input = Console.ReadLine(); number2 = Convert.ToInt32(input); Console.WriteLine(number2 - number1);
                        break;
                    case 3:
                        Console.WriteLine("Введите первое число"); input = Console.ReadLine(); number1 = Convert.ToInt32(input); Console.WriteLine("Введите второе число"); input = Console.ReadLine(); number2 = Convert.ToInt32(input); Console.WriteLine(number1 * number2);
                        break;
                    case 4:
                        Console.WriteLine("Введите первое число"); input = Console.ReadLine(); number1 = Convert.ToInt32(input); Console.WriteLine("Введите второе число"); input = Console.ReadLine(); number2 = Convert.ToInt32(input); Console.WriteLine(number1 / number2);
                        break;
                    case 5:
                        Console.WriteLine("Введите первое число"); input = Console.ReadLine(); number1 = Convert.ToInt32(input); Console.WriteLine("Введите степень"); input = Console.ReadLine(); number2 = Convert.ToInt32(input); int number3 = number1; for(int i = 0; i < number2-1; i++) {
                            number1 = number1 * number3;
                        }
                        Console.WriteLine(number1);
                        break;
                    case 6:
                        Console.WriteLine("Введите первое число"); input = Console.ReadLine(); number1 = Convert.ToInt32(input); Console.WriteLine(Math.Sqrt(number1));
                    break;
                    
                    case 7:
                        Console.WriteLine("Введите первое число"); input = Console.ReadLine(); number1 = Convert.ToInt32(input); number1 = number1 / 100 * 1; Console.WriteLine(number1);
                        break;
                    case 8:
                        Console.WriteLine("Введите первое число"); input = Console.ReadLine(); number1 = Convert.ToInt32(input); number2 = 1;  for (int i = 0; i < number1; i++) {

                            number2 = number2 * (1+i);
                        }
                        
                        Console.WriteLine(number2);

                        break;


                }
                    }
            while (operation != 9);

          
            

        }
    }
}