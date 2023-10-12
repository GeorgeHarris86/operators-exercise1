using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;

namespace operatorsexercise2
{
    public class AreaofCricle
    {

        public static void Main(string[] args)
        { 
                Console.WriteLine($"16/4 is 4");

                Console.WriteLine($"what is the radius of your circle?");

                var radius = double.Parse(Console.ReadLine());

            Console.WriteLine("The area of a circle with radius is");

            Console.WriteLine(3.14 * radius * radius);
        }    

    }

}    
   