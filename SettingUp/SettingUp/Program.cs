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
                Console.WriteLine(start);
            }

            Console.WriteLine("\r\nIs cable plugged into guitar? ");
            string cableIn = Console.ReadLine();
            if (cableIn=="yes")
            {
                Console.WriteLine("Now plug other end coming from the guitar into the speaker");
            }
            else if (cableIn=="no")
            {
                Console.WriteLine("You need to plug the guitar");
            }
        }
    }
}
