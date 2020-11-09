using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapLibrary
{
    public class Weapon
    {

        private int _minDamage;
        private int _maxDamage;
        private string _name;
        private int _BonusHitChance;
        private bool _multiShot;

        public int MaxDamage
        {
            get { return _maxDamage; }
            set { _maxDamage = value; }
        }
        public string name
        {
            get { return _name; }
            set { _name = value; }
        }
        public int BonusHitChance
        {
            get { return _BonusHitChance; }
            set { _BonusHitChance = value; }
        }
        public bool MultiShot
        {
            get { return _multiShot; }
            set { _multiShot = value; }
        }
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

        public Weapon(int minDamage, int maxDamage, string name, int bonusHitChance, bool multiShot)
        {
            MaxDamage = maxDamage;
            MinDamage = minDamage;
            name = name;
            BonusHitChance = bonusHitChance;
            multiShot = multiShot;
        }

        public override string ToString()
        {
            return string.Format("{0}\t{1} to {2} Damage\nBonus Hit: {3}%\t{4}",
                name,
                MinDamage,
                MaxDamage,
                BonusHitChance,
                MultiShot ? "Multi-Shot" : "Single-Shot");
        }
    }//end Class
}//end Namespace
