using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapLibrary
{
    public abstract class Character
    {

        private int _life;

        public string Name { get; set; }
        public int HitChance { get; set; }
        public int Evade { get; set; }
        public int Health { get; set; }

        public int Life
        {
            get { return _life; }
            set
            {
                if (value <= Health)
                {
                    _life = value;
                }
                else
                {
                    _life = Health;
                }
            }
        }
        public virtual int CalcEvade()
        {
            return Evade;
        }
        public virtual int CalcHitChance()
        {
            return HitChance;
        }
        public virtual int CalcDamage()
        {
            return 0;
        }

    }//end Class
}//end Namespace
