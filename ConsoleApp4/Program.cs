namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int programm = 4;
            do
            {
                Console.WriteLine("1.Игра Угадай число:");
                Console.WriteLine("2.Таблица умножения:");
                Console.WriteLine("3.Вывод делителей числа:");
                programm = Convert.ToInt32(Console.ReadLine());

                if (programm == 1)
                {
                    Random rand = new Random();
                    int secret = rand.Next(0, 101);
                    Console.WriteLine("Загадал число от 0 до 100.Попробуйте отгадать: ");
                    int MyNum = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите число");
                    while (true)
                    {
                        MyNum = int.Parse(Console.ReadLine());
                        if (MyNum == secret)
                        {
                            Console.WriteLine("Вы угадали. Молодцы.");
                            break;
                        }
                        else if (MyNum > secret)
                        {
                            Console.WriteLine("Надо меньше ");
                        }
                        else
                        {
                            Console.WriteLine("Надо больше");
                        }
                    }
                }
                else if (programm == 2)
                {
                    var table = new int[10, 10];
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            table[i, j] = i * j;
                        }
                    }
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            Console.Write("{0, 8}", table[i, j]);
                        }
                        Console.WriteLine();
                    }
                }
                else if (programm == 3)
                {
                    var n = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                    for (var c = 2; c <= n / 2; ++c)
                        if (n % c == 0)
                        {
                            Console.Write(" {0}", c);
                        }
                    Console.WriteLine();
                }





            }
            while (programm != 3);

        }
    }
}