namespace Pyramid_Pattern
{
    internal class PyramidPattern
    {
        static int n = 5;
        static void Simple_Pyramid()
        {

            for (int i = 1; i <= n; i++)
            {
                Console.Write(new string(' ', n - i));
                Console.WriteLine(new string('*', 2 * i - 1));
            }
        }
        static void Inverted_Simple_Pyramid()
        {

            for (int i = n; i >= 1; i--)
            {
                Console.Write(new string(' ', n - i));
                Console.WriteLine(new string('*', 2 * i - 1));
            }
        }
        static void Right_Angled_Triangle()
        {
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(new string('*', i));
            }
        }
        static void Inverted_Right_Angled_Triangle()
        {
            for (int i = n; i >= 1; i--)
            {
                Console.WriteLine(new string('*', i));
            }
        }
        static void Diamond_Shape()
        {
            for (int i = 1; i <= n; i++)
            {
                Console.Write(new string(' ', n - i));
                Console.WriteLine(new string('*', 2 * i - 1));
            }
            for (int i = n; i >= 1; i--)
            {
                Console.Write(new string(' ', n - i));
                Console.WriteLine(new string('*', 2 * i - 1));
            }
        }
        static void Hollow_Pyramid()
        {
            for (int i = 1; i <= n; i++)
            {
                Console.Write(new string(' ', n - i));

                for (int j = 1; j <= (2 * i - 1); j++)
                {
                    if (j == 1 || j == 2 * i - 1 || i == n)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
        static void Hollow_Diamond()
        {
            for (int i = 1; i <= n; i++)
            {
                Console.Write(new string(' ', n - i));

                for (int j = 1; j <= (2 * i - 1); j++)
                {
                    if (j == 1 || j == 2 * i - 1 || i == n)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            for (int i = n; i >= 1; i--)
            {
                Console.Write(new string(' ', n - i));

                for (int j = 1; j <= (2 * i - 1); j++)
                {
                    if (j == 1 || j == 2 * i - 1)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
        static void Pascal_Triangle()
        {
            for (int i = 0; i < n; i++)
            {
                int number = 1;
                Console.Write(new string(' ', (n - i)));

                for (int j = 0; j <= i; j++)
                {
                    Console.Write(number + " ");
                    number = number * (i - j) / (j + 1);
                }
                Console.WriteLine();
            }
        }
        static void Numeric_Pyramid()
        {
            for (int i = 1; i <= n; i++)
            {
                Console.Write(new string(' ', (n - i)));

                for (int j = 1; j <= (2 * i) - 1; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
        static void Zigzag_Pyramid()
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= 2 * n - 1; j++)
                {
                    if (j == n - i + 1 || j == n + i - 1 || i == n)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
        static void Numeric_pyramid()
        {
            for (int i = 1; i <= n; i++)
            {
                Console.Write(new string(' ', n - i));
                for (int j = 1; j <= i; j++)
                    Console.Write(j+" ");
                Console.WriteLine();
            }
        }
        static void Alphabet_pyramid()
        {
            char ch = 'A';
            for (int i = 1; i <= n; i++)
            {
                Console.Write(new string(' ', n - i));
                for (int j = 1; j <= i; j++)
                    Console.Write((char)(ch + j - 1) + " ");
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            Simple_Pyramid();
            Console.WriteLine("---------------------------------------------");
            Inverted_Simple_Pyramid();
            Console.WriteLine("---------------------------------------------");
            Right_Angled_Triangle();
            Console.WriteLine("---------------------------------------------");
            Inverted_Right_Angled_Triangle();
            Console.WriteLine("---------------------------------------------");
            Diamond_Shape();
            Console.WriteLine("---------------------------------------------");
            Hollow_Pyramid();
            Console.WriteLine("---------------------------------------------");
            Hollow_Diamond();
            Console.WriteLine("---------------------------------------------");
            Pascal_Triangle();
            Console.WriteLine("---------------------------------------------");
            Numeric_Pyramid();
            Console.WriteLine("---------------------------------------------");
            Zigzag_Pyramid();
            Console.WriteLine("---------------------------------------------");
            Numeric_pyramid();
            Console.WriteLine("---------------------------------------------");
            Alphabet_pyramid();
        }
    }
}

