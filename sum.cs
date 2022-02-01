
 
using System;
 
namespace DemoSai
{
    class Program
    {
        static void Main(string[] args)
        {
        
         int i,sum=0;
        Console.Write("input");
        Console.Write("\n");
        int n=int.Parse(Console.ReadLine());
        for(i=1;i<=n;i++)
        {
            Console.Write("{0} ",i);
            sum+=i;
        }
        Console.Write("\n");
        Console.Write (sum); 
    
        
        }
        
    }
}