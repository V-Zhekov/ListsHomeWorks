namespace SpisukNAkrainosti
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] number = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int min =number.Min();
            int max =number.Max();
            Console.WriteLine(string.Join(",",number.Where(n=> n==min || n == max)));
        }
    }
}
