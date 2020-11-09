using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapLibrary
{
    public class Fight
    {

        public static void DoAttack(Character attacker, Character defender)
        {
            Random rand = new Random();
            int diceRoll = rand.Next(1, 51);
            System.Threading.Thread.Sleep(25);

            if (diceRoll <= (attacker.CalcHitChance() - defender.CalcEvade()))
            {
                int damageDone = attacker.CalcDamage();
                defender.Life -= damageDone;

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("{0} hit {1} for {2} damage!", attacker.Name, defender.Name, damageDone);
                Console.ResetColor();
            }
            else
            {
                Console.WriteLine("{0} missed!", attacker.Name);
            }
        }
        public static void DoBattle(Player player, Monster monster)
        {
            DoAttack(player, monster);
            if (monster.Life > 0)
            {
                DoAttack(monster, player);
            }
        }
    }//end Class
}//end Namespace
