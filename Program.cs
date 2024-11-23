namespace topLevelStatements
{
    internal class Program
    {
        static void first_task()
        {
            int multiplyNumbersInRange(int start, int end)
            {
                int product = 1;
                for (int i = start; i <= end; i++)
                {
                    product *= i;
                }
                return product;
            }

            int result = multiplyNumbersInRange(1, 5);
            Console.WriteLine("Product: " + result);
        }

        static void second_task()
        {
            bool isFibonacciNumber(int number)
            {
                if (number == 0 || number == 1)
                {
                    return true;
                }

                int previous = 0;
                int current = 1;

                while (current < number)
                {
                    int next = previous + current;
                    previous = current;
                    current = next;

                    if (current == number)
                    {
                        return true;
                    }
                }

                return false;
            }

            int number = 8;
            bool isFibonacci = isFibonacciNumber(number);
            Console.WriteLine("Is Fibonacci Number: " + isFibonacci);
        }

        static void third_task()
        {
            void sortArray(int[] array, bool ascending)
            {
                int n = array.Length;
                for (int i = 0; i < n - 1; i++)
                {
                    for (int j = 0; j < n - i - 1; j++)
                    {
                        if (ascending)
                        {
                            if (array[j] > array[j + 1])
                            {
                                int temp = array[j];
                                array[j] = array[j + 1];
                                array[j + 1] = temp;
                            }
                        }
                        else
                        {
                            if (array[j] < array[j + 1])
                            {
                                int temp = array[j];
                                array[j] = array[j + 1];
                                array[j + 1] = temp;
                            }
                        }
                    }
                }
            }

            int[] numbers = { 5, 2, 8, 1, 9 };
            bool ascending = true; 
            sortArray(numbers, ascending);

            Console.WriteLine("Sorted Array:");
            foreach (int number in numbers)
            {
                Console.Write(number + " ");
            }
        }

        class City
        {

        }

        static void fours_task()
        {
            
        }

        static void Main(string[] args)
        {
            //first_task();
            //second_task();
            //third_task();
            //fours_task();

        }
    }
}
