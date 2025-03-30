namespace ConsoleApp1
{
     class Program
    {
        static void Main()
        {
            Weapon gun = new Weapon(30, "single");
            bool running = true;

            while (running)
            {
                Console.Write("Enter command (1-atış, 2-qalan, 3-yenidən yükləmə, 4-dəyişmə rejimi,5-end): ");
                string command = Console.ReadLine();
                switch (command)
                {
                    case "1":
                        gun.Shood();
                        break;

                    case "2":
                        Console.WriteLine(gun.GetRemainBulletCount());
                        break;
                    case "3":
                        gun.Reload();
                        break;

                    case "4":
                        gun.ChangeFireMode();
                        break;
                    case "5":
                        Console.WriteLine("end");
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Yanlis");
                        break;
                }
            }



         }


      }
 }
