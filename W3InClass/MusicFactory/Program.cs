using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace MusicFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Do you want to play some music?");
           string answer= Console.ReadLine();
            if (answer == "Yes")
            {
                Console.WriteLine("Play music");
                using (SoundPlayer player = new SoundPlayer(@"C:\Users\Asus\Downloads\mind.wav"))


                {
                    player.PlaySync();
                   
                }

            }
            else if (answer == "No")
            {
                Console.WriteLine("Goodbye!");

            }

            else { Console.WriteLine("Wroong input!"); }
               
           

        }
    }
}
