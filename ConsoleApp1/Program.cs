namespace ConsoleApp1
{
    public class Class1
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("(Выйти 0) Выберите задание из 2: ");
                var choice = Convert.ToString(Console.ReadLine());
                switch (choice)
                {
                    case "1":
                        Exercise1();
                        break;
                    case "2":
                        Exercise2();
                        break;
                    case "0":
                        return;
                    default:
                        Console.WriteLine("\nНеверный выбор\n");
                        break;
                }
            }
        }

        public static void Exercise1()
        {
            int[] array = GenerateRandomArray(10, 0, 100);
            Console.WriteLine();
            PrintArray(array);
        }

        public static void Exercise2()  
        {
            int[] weather = { 1, 0, 1, 1, 0};

            int initialHeight = 200;

            int finalHeight = CalculateFinalHeight(initialHeight, weather);

            Console.WriteLine($"\nКонечная высота улитки: {finalHeight} см\n");
        }

        public static int[] GenerateRandomArray(int size, int minValue, int maxValue)
        {
            int[] array = new int[size];

            for (int i = 0; i < size; i++)
            {
                array[i] = Random.Shared.Next(minValue, maxValue + 1);
            }

            return array;
        }

        public static void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine("\n");
        }

        public static int CalculateFinalHeight(int initialHeight, int[] weatherData)
        {
            int climbHeight = 5;
            int descentHeight = 3;
            int treeHeight = 500;

            int currentHeight = initialHeight;

            foreach (int day in weatherData)
            {
                if (day == 1)
                {
                    currentHeight += climbHeight;
                }
                else if (day == 0)
                {
                    currentHeight -= descentHeight;
                }
                currentHeight = Math.Min(currentHeight, treeHeight);
                currentHeight = Math.Max(currentHeight, 0);
            }

            return currentHeight;
        }
    }



}