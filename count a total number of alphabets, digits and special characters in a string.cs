
namespace Demosra
{
    class ADC
      {
        static void Main(string[] args)
        {
         string str;
        int alphabet, digit, specialchar, i, l;
        alphabet = digit = specialchar = i = 0;
 
        Console.Write("string : ");
        str = Console.ReadLine();
        l = str.Length;
 
        while (i < l)
        {
            if ((str[i] >= 'a' && str[i] <= 'z') || (str[i] >= 'A' && str[i] <= 'Z'))
            {
                alphabet++;
            }
            else if (str[i] >= '0' && str[i] <= '9')
            {
                digit++;
            }
            else
            {
                specialchar++;
            }
 
            i++;
        }
 
        Console.Write("Alphabets: {0}\n", alphabet);
        Console.Write("Digits : {0}\n", digit);
        Console.Write("Special characters: {0}\n\n", specialchar);
 
        Console.ReadLine();
        }
    }
}
  