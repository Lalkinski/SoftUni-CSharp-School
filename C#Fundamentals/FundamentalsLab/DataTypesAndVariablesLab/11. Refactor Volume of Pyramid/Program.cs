/*
2.5 
4.2
5.3


// Function to find the  
   // volume of square pyramid 
   float volumeSquare(int b, int h) 
   { 
       float vol = (0.33) * b *  
                        b * h; 
       return vol; 
   } 

 */

namespace _11._Refactor_Volume_of_Pyramid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Length: ");
            decimal length = decimal.Parse(Console.ReadLine());

            Console.Write("Width: ");
            decimal width = decimal.Parse(Console.ReadLine());

            Console.Write("Height: ");
            decimal height = decimal.Parse(Console.ReadLine());

            height = (length * width * height) / 3;
            Console.Write($"Pyramid Volume: {height:f2}");
        }
    }
}
