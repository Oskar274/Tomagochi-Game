using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2
{
    public class Tomagochi
    {
        public int hp = 100;
        public int starving = 100;
        public int happiness = 100;


        public void Static()
        {
            Console.WriteLine("  /|_/|  ");
            Console.WriteLine(" ( o.o ) ");
            Console.WriteLine(" > ^ < ");

            Console.WriteLine();
            Console.WriteLine("Status:");
            Console.WriteLine($"hp {hp}");
            Console.WriteLine($"starving {starving}");
            Console.WriteLine($"happiness {happiness}");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("1. Feed");
            Console.WriteLine("2. Walk");
            Console.WriteLine("3. heal");
            Console.WriteLine("4. Afk");
            Console.WriteLine("5. Exit");
        }

        public void Eat()
        {
            Console.WriteLine("   /|_/|         _________");
            Console.WriteLine("  ( o.o )______ / Feed me \\");
            Console.WriteLine("   > ^ <        \\ Me  !   /");
            Console.WriteLine("                 ---------");

            Console.WriteLine();
            Console.WriteLine("Status:");
            Console.WriteLine($"hp {hp}");
            Console.WriteLine($"starving {starving}");
            Console.WriteLine($"happiness {happiness}");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("1. Feed");
            Console.WriteLine("2. Walk");
            Console.WriteLine("3. heal");
            Console.WriteLine("4. Afk");
            Console.WriteLine("5. Exit");
        }


        public void Walk()
        {
            Console.WriteLine("   /|_/|         _________");
            Console.WriteLine("  ( o.o )______ / Let's   \\");
            Console.WriteLine("   > ^ <        \\ go for a/");
            Console.WriteLine("                 \\ walk! /");
            Console.WriteLine("                  -------");

            Console.WriteLine();
            Console.WriteLine("Status:");
            Console.WriteLine($"hp {hp}");
            Console.WriteLine($"starving {starving}");
            Console.WriteLine($"happiness {happiness}");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("1. Feed");
            Console.WriteLine("2. Walk");
            Console.WriteLine("3. Heal");
            Console.WriteLine("4. Afk");
            Console.WriteLine("5. Exit");
        }

        public void Heal()
        {
            Console.WriteLine("   /|_/|         _________");
            Console.WriteLine("  ( o.o )______ / I need  \\");
            Console.WriteLine("   > ^ <        \\ healing /");
            Console.WriteLine("                 ---------");

            Console.WriteLine();
            Console.WriteLine("Status:");
            Console.WriteLine($"hp {hp}");
            Console.WriteLine($"starving {starving}");
            Console.WriteLine($"happiness {happiness}");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("1. Feed");
            Console.WriteLine("2. Walk");
            Console.WriteLine("3. Heal");
            Console.WriteLine("4. Afk");
            Console.WriteLine("5. Exit");
        }

        public void Thank()
        {
            Console.WriteLine("   /|_/|         _________");
            Console.WriteLine("  ( o.o )______ / Thank   \\");
            Console.WriteLine("   > ^ <        \\ you!    /");
            Console.WriteLine("                 ---------");

            Console.WriteLine();
            Console.WriteLine("Status:");
            Console.WriteLine($"hp {hp}");
            Console.WriteLine($"starving {starving}");
            Console.WriteLine($"happiness {happiness}");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("1. Feed");
            Console.WriteLine("2. Walk");
            Console.WriteLine("3. Heal");
            Console.WriteLine("4. Afk");
            Console.WriteLine("5. Exit");
        }








    }
}
