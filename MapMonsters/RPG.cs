using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MapLibrary;

namespace MapMonster
{ 
    public class RPG : Monster
    {

        public bool FliesFast { get; set; }

        public RPG(string name, int life, int maxLife, int hitChance, int evade, int minDamage, int maxDamage, string description, bool fliesFast) :base(name, life, maxLife, hitChance, evade, minDamage, maxDamage, description)
        {
            FliesFast = fliesFast;
        }
        public RPG()
        {
            MaxLife = 100;
            MaxDamage = 25;
            Name = "RPG";
            Life = 100;
            HitChance = 30;
            Evade = 5;
            MinDamage = 1;
            Description = "Levatating RPG, need to find cover before you explode!!";
            FliesFast = FliesFast;
        }
        public override int CalcEvade()
        {
            int calculatedEvade = Evade;

            if (FliesFast)
            {
                calculatedEvade += calculatedEvade / 5;
            }
            return calculatedEvade;
        }


    }
}
