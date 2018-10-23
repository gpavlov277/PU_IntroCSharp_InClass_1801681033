using System;
using System.IO;

namespace CandyShop
{
    class Program
    {
        static void Main(string[] args)
            
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

         


            string[] lines = File.ReadAllLines(@"C:\Users\Asus\Desktop\Week3\PU_IntroCSharp_InClass_1801681033\PU_IntroCSharp_InClass_1801681033\W3InClass\CandyShop\files\students.txt");
           
            System.Console.WriteLine("Contents of students.txt = ");
            foreach (string line in lines)
            {
                string[] currentElements = line.Split(' ');


                string firstName = currentElements[1];
                string lastName = currentElements[3];
                string fullName = $"{firstName}{lastName}";
                int sum = 0;

                for (int i = 0; i < firstName.Length; i++)
                {
                    sum += (int)firstName[i];

                }

                Console.WriteLine($"Candy for {fullName}->{sum}");
            }

        }
    }
}
