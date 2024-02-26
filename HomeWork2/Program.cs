namespace HomeWork2
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Random random = new Random();
            Tomagochi t = new Tomagochi();
            ConsoleKeyInfo key;
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            int delete = 0;
            int da = 0;
            do
            {
                t.Static();
                Thread.Sleep(4000);
                Console.Clear();
                

                do
                {
                    da = random.Next(1, 4);
                }
                while ( da == delete );

                if (da == 1)
                {
                    t.starving -= 20;
                    t.Eat();
                    delete = 1;
                    if(t.starving <= 0)
                    {
                        t.hp = -20;
                    }
                    
                }
                else if (da == 2)
                {
                    t.happiness -= 20;
                    t.Walk();
                    delete = 2;
                    if (t.happiness <= 0)
                    {
                        t.hp = -20;
                    }
                }
                else
                {
                    t.hp -= 20;
                    t.Heal();
                    delete = 3;
                }
                key = Console.ReadKey(true);
                if (key.KeyChar == '1')
                {
                    Console.WriteLine();
                    Console.WriteLine();
                    if (t.starving - 20 > 80)
                    {
                        t.starving = 100;
                        Console.WriteLine("u feed ur Tomagochi");
                    }
                    else if(t.starving - 20 < 80)
                    {
                        t.starving += 20;
                        Console.WriteLine("u feed ur Tomagochi");
                    }
                    else
                    {
                        Console.WriteLine("ur tomagochi doesn't want eat");
                    }
                    if (delete != 1)
                    {
                        t.hp -= 20;
                    }


                }
                else if (key.KeyChar == '2')
                {
                    Console.WriteLine();
                    Console.WriteLine();

                    if (t.starving - 20 > 80)
                    {
                        t.starving = 100;
                        Console.WriteLine("u walk with ur Tomagochi");
                    }
                    else if (t.starving - 20 < 80)
                    {
                        t.starving += 20;
                        Console.WriteLine("u walk with ur Tomagochi");
                    }
                    else
                    {
                        Console.WriteLine("ur tomagochi doesn't want walk with u right now");
                    }
                    if (delete != 2)
                    {
                        t.hp -= 20;
                    }
                }
                Thread.Sleep(3000);
                Console.Clear();

            }
            while (t.hp > 0);
        }
    }
}