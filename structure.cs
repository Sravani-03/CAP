
namespace Demosra
{
     
    public struct Student {
    public string Name;
    public int Class;
    public string Gender;
    }
    class Vstruct
    {
        public static void Main(string[] args)
        {

        Student S1;
        S1.Name = "Sravani";
        S1.Class = 5;
        S1.Gender = "F";

        Console.WriteLine("Name : {0}", S1.Name);
        Console.WriteLine("Class: {0}",S1.Class);
        Console.WriteLine("Gender : {0}",S1.Gender);

        }
    }
}