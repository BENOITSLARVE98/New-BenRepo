using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SettingUp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Clear();


            SoundSystem sound = new SoundSystem();


            //Welcome user
            Console.WriteLine("Hello and Welcome to this program\r\nWe will be setting up your guitar for practice!");
            Console.WriteLine("\r\nAre you ready to get started? yes / no");
            string start = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(start))
            {
                Console.WriteLine("ERROR !!!! " + "\r\nAre you ready to get started? yes / no");
                start = Console.ReadLine();
            }
            while (!(start=="yes"))
            {
                Console.WriteLine("You are Joking!! Let's jump right in.");
                break;

            }

            Console.WriteLine("\r\nIs cable plugged into guitar? yes / no ");
            string CheckCableIn = Console.ReadLine();
            if (CheckCableIn == "yes")
            {
                Console.WriteLine("Now plug other end coming from the guitar into the speaker");

            }
            else if (CheckCableIn == "no")
            {
                Console.WriteLine("You need to plug the guitar");
                Console.WriteLine("Is cable plugged into guitar?");
                CheckCableIn = Console.ReadLine();
            }

            //2nd step
            Console.WriteLine("\r\nIs cable plugged in properly? yes / no ");
            string ChekCableProperly = Console.ReadLine();
            if (ChekCableProperly == "yes")
            {
                Console.WriteLine("Please strum the guitar!!");
            }
            else if (ChekCableProperly == "no")
            {
                Console.WriteLine("Plug it in properly to continue");
                Console.WriteLine("Is cable plugged in properly ?");
                ChekCableProperly = Console.ReadLine();
                   
            }

            //3rd step
            Console.WriteLine("Is there any sound? yes / no ");
            string checkSound = Console.ReadLine();

            



            if (checkSound == "yes")
            {
                Console.WriteLine("Congrats !! You are ready to play. ");
            }
            else if (checkSound == "no")
            {
                Console.WriteLine("OOPS ,You current guitar volume is set to {0} ",sound.GetVolume());
                Console.WriteLine("Would you like to adjust your volume. Type- (1): for Max=10   (2): for Med=5  (3): for Low=2");
                string adjustString = Console.ReadLine();
                int adjust;
                
                while (!int.TryParse(adjustString, out adjust))
                {
                    Console.WriteLine("ERROR !! TRY AGAIN");
                    Console.WriteLine("Would you like to adjust your volume. Type- (1): for Max=10   (2): for Med=5  (3): for Low=2");
                }
                 if (adjust == 1)
                {
                     sound.SetVolume(10);
                    Console.WriteLine("Your current volume is now set to "+sound.GetVolume());
                }
                 else if (adjust == 2)
                {
                    sound.SetVolume(5);
                    Console.WriteLine("Your current volume is now set to " + sound.GetVolume());
                }
                 else if (adjust == 3)
                {
                    sound.SetVolume(2);
                    Console.WriteLine("Your current volume is now set to " + sound.GetVolume());
                }
                

            }

            
        }
    }
}
