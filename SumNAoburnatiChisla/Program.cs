namespace SumNAoburnatiChisla
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                        .Split(' ') 
                        .Select(int.Parse) 
                        .ToArray();

            int sum = numbers.Select(n => ReverseNumber(n)).Sum();
            Console.WriteLine(sum);
        }

        static int ReverseNumber(int num)
        {
            int reversed = 0;
            while (num != 0)
            {
                reversed = reversed * 10 + num % 10;
                num /= 10;
            }
            return reversed;
        }
    }
}
