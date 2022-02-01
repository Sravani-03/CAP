
namespace Demosra
{
    internal class NewBaseType
    {
        static void Main(string[] args)
        {
            int i, j, r, k = 1;

            Console.WriteLine("input");
            Console.WriteLine("\n");

            r = int.Parse(Console.ReadLine());

            for (i = 1; i <= r; i++)
            {
                for (j = 1; j <= i; j++)
                    Console.Write("{0} ", k++);

                Console.WriteLine("\n");
            }


        }
    }
}
  