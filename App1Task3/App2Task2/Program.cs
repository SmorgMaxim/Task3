namespace nambers //Smorg Maxim Hillel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Znachenia A:");
           int A;
            A = int.Parse(Console.ReadLine());
            Console.WriteLine("Znachenia B:");
            int B;
            B = int.Parse(Console.ReadLine());
            if (A == B)
            {
                Console.WriteLine("Znachenia ravni");
            }
            else
            {
                Console.WriteLine("Znachenia ne ravni");
            }
            if (A > B)
            {
                Console.WriteLine("A bolshe chem B");
            }
            else
            {
                Console.WriteLine("A menshe chem B");
            }
        }
    }
}