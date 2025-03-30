using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Weapon
    {
       
            private int capasity;
            private int bullets;
            private string fireMode;
            public Weapon(int capacity, string fireMode)
            {
                this.capasity = capacity;
                this.fireMode = fireMode;
                this.bullets = capacity;
                while (capacity <= 0)
                {
                    Console.WriteLine("dəyər daxil edin");
                    capacity = Convert.ToInt32(Console.ReadLine());
                }


                while (fireMode != "single" && fireMode != "auto")
                {
                    Console.WriteLine("tək və ya avtomatik  daxil edin:");
                    fireMode = Console.ReadLine();
                }
            }
            public void Shood()
            {
                if (bullets==0)
                {
                    Console.WriteLine("güllə yoxdu");

                }
                else
                {
                    if (fireMode=="single")
                    {
                        bullets--;
                        Console.WriteLine("güllə atıldı");
                    }
                    else
                    {
                        Console.WriteLine("gulle yoxdu");
                        bullets = 0;
                    }

                }


            }
            public int GetRemainBulletCount()
            {
                return capasity-bullets;

            }
            public void Reload()
            {
                bullets = capasity;
                Console.WriteLine("Doldu");
            }
            public void ChangeFireMode()
            {
                if (fireMode == "single")
                {
                    fireMode = "auto";
                }
                else
                {
                    fireMode = "single";
                }
            }

     }

    
}
