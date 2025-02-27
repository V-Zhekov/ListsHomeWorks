using System.Globalization;

namespace SpisukNAcetniCisla
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] number=Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            Console.WriteLine(string.Join("",number.Where(n=>n%2==0)));
        }
    }
}
