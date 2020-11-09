using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MapLibrary;
using MapMonster;

namespace MyDungeon
{
    public class Dungeon
    {
        static void Main(string[] args)
        {

            Console.Title = "WELCOME TO SHIPMENT";
            Console.WriteLine("May you survive the map...\n");
            int score = 0;

            Weapon fireShotgun = new Weapon(1, 15, "Fire Shotgun", 5, false); 
            Player player = new Player("Paw KC", 50, 5, 50, 50, Name.AlexMason, fireShotgun);

            bool exit = false;
            do
            {
                Console.WriteLine(GetMap());

                RPG r1 = new RPG();
                RPG r2 = new RPG("Game Wrecker", 40, 40, 50, 15, 1, 10, "The guys have RPG's, everyone stay in spawn...", true);

                RPG[] rpgs = { r1, r2, r2, r1, r1 };

                Random rand = new Random();
                int randNbr = rand.Next(rpgs.Length);
                RPG rpg = rpgs[randNbr];

                Console.WriteLine("\nOn the map: " + rpg.Name);
            } while (!exit);

            Console.WriteLine("You've defeated " + score + " enemy" + ((score == 1)? "." : "s."));
         }//end Main()

        private static string GetMap()
        {
            string[] maps =
            {
                "11 rusted shipping crates sit on either side of you, stacked 5 containers tall, with the last being in front. Rain is falling.",
                "You walk around the corner to see your enemy staring back at you with killer intent.",
                "You look to the back of a shipping crate as you enter, and can see the silhouette of your enemy in the dark. Barely any light shines through from behind you.",
                "You linger onto a rainy courtyard, mud is getting thick, with a deep smell of iron in the air.",
                "Walking down the dark, damp alley. You witness unknown figures dashing from side to side from where you entered and at the end of the alley.",
                "Escaping the heavy rain, you enter a dark brick building. While walking through you stumble upon a room where several unknowns are sitting around a light.",
            };
            Random rand = new Random();
            int userNbr = rand.Next(maps.Length);
            string map = maps[userNbr];
            return map;

        }
    }//end Class
}//end Namespace
