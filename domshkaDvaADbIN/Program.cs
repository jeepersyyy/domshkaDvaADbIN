namespace domshkaDvaADbIN
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            double coef = 0.0;
            Random random = new Random();

            for (; ; )
            {
                Console.Clear();
                Console.Write("ставка: ");
                int.TryParse(Console.ReadLine(), out a);

                if (a >= 5 && a <= 100 && a % 5 == 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("ввод не верный, придерживайтесь правил!");
                    Thread.Sleep(1000);
                }
            }

            int number1 = random.Next(1, 10);
            int number2 = random.Next(1, 10);
            int number3 = random.Next(1, 10);

            Console.WriteLine("\n");
            Console.WriteLine("   |   |   ");
            Console.WriteLine("   |   |   ");



            for (int i = 0; i < 50; i++)
            {
                number1 = random.Next(1, 10);
                number2 = random.Next(1, 10);
                number3 = random.Next(1, 10);

                string one = $"{(number1 - 2 + 9) % 9 + 1} | {(number2 - 2 + 9) % 9 + 1} | {(number3 - 2 + 9) % 9 + 1}";
                string two = $"{number1} | {number2} | {number3}  <--";
                string three = $"{(number1 % 9) + 1} | {(number2 % 9) + 1} | {(number3 % 9) + 1}";

                UpdateRow(2, one);
                UpdateRow(3, two);
                UpdateRow(4, three);

                Thread.Sleep(10);
            }
            for (int o = 0; o < 50; o++)
            {
                number2 = random.Next(1, 10);
                number3 = random.Next(1, 10);

                string one = $"{(number1 - 2 + 9) % 9 + 1} | {(number2 - 2 + 9) % 9 + 1} | {(number3 - 2 + 9) % 9 + 1}";
                string two = $"{number1} | {number2} | {number3}  <--";
                string three = $"{(number1 % 9) + 1} | {(number2 % 9) + 1} | {(number3 % 9) + 1}";

                UpdateRow(2, one);
                UpdateRow(3, two);
                UpdateRow(4, three);

                Thread.Sleep(10);
            }
            for (int p = 0; p < 50; p++)
            {
                number3 = random.Next(1, 10);

                string one = $"{(number1 - 2 + 9) % 9 + 1} | {(number2 - 2 + 9) % 9 + 1} | {(number3 - 2 + 9) % 9 + 1}";
                string two = $"{number1} | {number2} | {number3}  <--";
                string three = $"{(number1 % 9) + 1} | {(number2 % 9) + 1} | {(number3 % 9) + 1}";

                UpdateRow(2, one);
                UpdateRow(3, two);
                UpdateRow(4, three);

                Thread.Sleep(10);
            }


            if (number1 == number2 && number2 == number3)
            {
                coef = number1 * 1.5;
                if (number1 == 7 && number2 == 7 && number3 == 7)
                {
                    coef = number1 * 150 * 1.5;
                    Console.WriteLine("Джекпот!");
                }

            }
            else if (number1 == number2)
            {
                coef = number1 * 1.25;
                if (number1 == 7 && number2 == 7)
                {
                    coef = number1 * 15 * 1.25;
                    Console.WriteLine("Мини Джекпот!");
                }
            }
            else if (number3 == number2)
            {
                coef = number3 * 1.25;
                if (number3 == 7 && number2 == 7)
                {
                    coef = number1 * 15 * 1.25;
                    Console.WriteLine("Мини Джекпот!");
                }
            }
            else if (number3 == number1)
            {
                coef = number3 * 1.25;
                if (number3 == 7 && number1 == 7)
                {
                    coef = number1 * 15 * 1.25;
                    Console.WriteLine("Мини Джекпот!");
                }
            }
            else if (number1 == 7 || number2 == 7 || number3 == 7)
            {
                coef = 1.6;
            }
            else if (number1 == 9 || number2 == 9 || number3 == 9)
            {
                coef = 1.35;
            }


            if (coef > 0)
            {
                double money = a * coef;
                Console.WriteLine($"\n\nПоздравляю! Вы выиграли {money}$!");
            }
            else
            {
                Console.WriteLine("\n\nВы проиграли, это всё казино!");
            }
        }

        static void UpdateRow(int row, string content)
        {
            Console.SetCursorPosition(0, row);
            Console.Write(content.PadRight(Console.WindowWidth));
        }
    }
}


/*    вторая идея
 *    
     for (int i = 0; i < 33; i++)
     {
          number1 = random.Next() % 10;
          number2 = random.Next() % 10;
          number3 = random.Next() % 10;
         Console.Write($"ставка: {a}\n\n");
         Console.WriteLine($"{(number1 - 2 + 9) % 9 + 1} | {(number2 - 2 + 9) % 9 + 1} | {(number3 - 2 + 9) % 9 + 1}");
         Console.WriteLine($"{number1} | {number2} | {number3}");
         Console.WriteLine($"{(number1 % 9) + 1} | {(number2 % 9) + 1} | {(number3 % 9) + 1}");
         Thread.Sleep(10);
         Console.Clear();

     }
     for (int o = 0; o < 33; o++)
     {
         number2 = random.Next() % 10;
         number3 = random.Next() % 10;
         Console.Write($"ставка: {a}\n\n");
         Console.WriteLine($"{(number1 - 2 + 9) % 9 + 1} | {(number2 - 2 + 9) % 9 + 1} | {(number3 - 2 + 9) % 9 + 1}");
         Console.WriteLine($"{number1} | {number2} | {number3}");
         Console.WriteLine($"{(number1 % 9) + 1} | {(number2 % 9) + 1} | {(number3 % 9) + 1}");
         Thread.Sleep(10);
         Console.Clear();

     }
     for (int p = 0; p < 33; p++)
     {
         number3 = random.Next() % 10;
         Console.Write($"ставка: {a}\n\n");
         Console.WriteLine($"{(number1 - 2 + 9) % 9 + 1} | {(number2 - 2 + 9) % 9 + 1} | {(number3 - 2 + 9) % 9 + 1}");
         Console.WriteLine($"{number1} | {number2} | {number3}");
         Console.WriteLine($"{(number1 % 9) + 1} | {(number2 % 9) + 1} | {(number3 % 9) + 1}");
         Thread.Sleep(10);
         Console.Clear();

     }



     первая идея

     for (int i = 0; i <= number1; i++)
     {
         Console.Write($"ставка: {a}\n");
         Console.WriteLine($"{i}");
         Thread.Sleep(100);
         Console.Clear();
     }

     for (int o = 0; o <= number2; o++)
     {
         Console.Write($"ставка: {a}\n");
         Console.WriteLine($"{number1} {o}");
         Thread.Sleep(100);
         Console.Clear();
     }

     for (int p = 0; p <= number3; p++)
     {
         Console.Write($"ставка: {a} \n");
         Console.WriteLine($"{number1} {number2} {p}");
         Thread.Sleep(100);
         Console.Clear();
     }

     Console.Write($"ставка: {a} \n");
     Console.WriteLine($"{number1} {number2} {number3}");



 жалкая попытка

Console.Write($"ставка: {a}\n\n");
Console.WriteLine($"{(number1 - 2 + 9) % 9 + 1} | {(number2 - 2 + 9) % 9 + 1} | {(number3 - 2 + 9) % 9 + 1}");
Console.WriteLine($"{number1} | {number2} | {number3}");
Console.WriteLine($"{(number1 % 9) + 1} | {(number2 % 9) + 1} | {(number3 % 9) + 1}");

string text = $"{(number1 - 2 + 9) % 9 + 1} | {(number2 - 2 + 9) % 9 + 1} | {(number3 - 2 + 9) % 9 + 1}\n" +
            $"{number1} | {number2} | {number3}\n" +
            $"{(number1 % 9) + 1} | {(number2 % 9) + 1} | {(number3 % 9) + 1}";


Console.WriteLine(text);







 секретный документ

// Generating random numbers.

// 1. Create Randomizer object.
Random random = new Random();

// 2. Generate random integer.

// 2.1 Generate random integer in range [ 0 ; int.MaxValue ]
int number1 = random.Next();
// 2.2 Generate random integer in range [ 0 ; 100 ). 100 NOT INCLUDED!!!
int number2 = random.Next(100);
// Alternative
number2 = random.Next() % 100;
// 2.3 Generate random integer in range [ -100 ; 100 ). 100 NOT INCLUDED!!!
int number3 = random.Next(-100, 100);
// Alternative
number3 = random.Next() % 200 - 100;
// Use method NextInt64() for generating long values.

// 3. Generate random floating-point values.

// 3.1 Generate random float in range (0;1)
float number4 = random.NextSingle();

// 3.2 Generate random double in range (0;1)
double number5 = random.NextDouble();

// 3.3 Generate random float/double in range (-5;5)
number5 = number5 * 10 - 5;

// Alternative(without creating Randomizer object)
int number6 = Random.Shared.Next(); // also works with other Randomizer methods.

// Generating predictable random numbers.
// Will be useful for testing methods that works with random values.

// 1. Create Randomizer object.

int seed = 100; // Any positive number.

Random random = new Random(100);

int number1 = random.Next(); // 2080427802
int number2 = random.Next(); // 341851734
int number3 = random.Next(); // 1431988776
// and so on...

// for each {seed} sequence of values will be different.

*/


