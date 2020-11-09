using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapLibrary
{
    public class Monster : Character
    {

        private int _minDamage;
        
        public int MaxDamage { get; set; }
        public string Description { get; set; }

        public int MinDamage
        {
            get { return _minDamage; }
            set
            {
                if (value > 0 && value <= MaxDamage)
                {
                    _minDamage = value;
                }
                else
                {
                    _minDamage = 1;
                }
            }
        }
        public int MaxLife { get; set; }

        public Monster()
        {

        }
        public Monster(string name, int life, int maxLife, int hitChance, int evade, int minDamage, int maxDamage, string description)
        {
            MaxLife = maxLife;
            MaxDamage = maxDamage;
            Name = name;
            Life = life;
            HitChance = hitChance;
            Evade = evade;
            MinDamage = minDamage;
            Description = description;
        }
        public override string ToString()
        {
            return string.Format("\n****** ENEMY TIME ******\n{0}\nLife: {1} of {2}\nDamage: {3} to {4}\nEvade: {5}\nDescription:\n{6}\n",
                Name,
                Life,
                MaxLife,
                HitChance,
                Evade,
                MinDamage,
                MaxDamage,
                Description);
        }
        public override int CalcDamage()
        {
            Random rand = new Random();
            return rand.Next(MinDamage, MaxDamage + 1);
        }
    }//end Class
}//end Namespace
