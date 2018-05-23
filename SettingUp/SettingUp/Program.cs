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
            //Welcome user
            Console.WriteLine("Hello and Welcome to this program\r\nWe will be setting up your guitar for practice!");
            Console.WriteLine("\r\nAre you ready to get started? yes / no");
            string start = Console.ReadLine();
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
            while (CheckCableIn == "no")
            {
                Console.WriteLine("You need to plug the guitar");
                Console.WriteLine("Is cable plugged into guitar?");
                CheckCableIn = Console.ReadLine();
            }

            //Next step
            Console.WriteLine("\r\nIs cable plugged in properly?");
            


        }
    }
}
