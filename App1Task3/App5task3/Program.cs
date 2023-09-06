namespace Numb// Smorg Hilel
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            a = int.Parse(Console.ReadLine());
            if (a % 3 == 0 & a % 5 != 0)
            {
                Console.WriteLine("Fizz");
            }
            if (a % 5 == 0 & a % 3 != 0)
            {
                Console.WriteLine("Bazz");
            }
            if (a % 3 == 0 & a % 5 == 0)
            {
                Console.WriteLine("FizzBazz");
            }
        }
    }
}