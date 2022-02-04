
namespace Demosra
{
     
    public class IndexCreation 
    {
        private string[] val = new string[3];
        public string this[int index]{
            get
        {
 
            return val[index];
        }
        set
        {
            val[index] = value;
        }
        }
    
    }
    class Indexersinc
    {
        public static void Main(string[] args)
        {

       IndexCreation ic = new IndexCreation();
        ic[0] = "JAVA";
        ic[1] = "C#";
        ic[2] = "Python";

        Console.WriteLine("first: {0}", ic[0]);
        Console.WriteLine("Second: {0}",ic[1]);
        Console.WriteLine("third : {0}",ic[2]);

        }
    }
}