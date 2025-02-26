namespace MagsimalnaPoredicha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] number = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int start = 0, length = 1;
            int currentStart=0, currentLength = 1;
            for (int i = 0; i < number.Length; i++)
            {
                if (number[i] == number[i - 1])
                {
                    currentLength++;
                }
                else
                {
                    currentStart = i;
                    currentLength = 1;
                }
                if (currentStart > length)
                {
                    length = currentStart;
                    start = currentStart;

                }
            
            }
            Console.WriteLine(string.Join(" ", number.Skip(start).Take(length)));
        }
    }
}
