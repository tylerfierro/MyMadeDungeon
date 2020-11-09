using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapLibrary
{
    public sealed class Player : Character 
    {

        public Name CharacterName { get; set; }
        public Weapon WeaponChoice { get; set; }

        public Player(string name, int hitChance, int evade, int life, int maxLife, Name charactername, Weapon weaponchoice)
        {
            maxLife = maxLife;
            Name = name;
            HitChance = hitChance;
            Evade = Evade;
            Life = life;
            CharacterName = CharacterName;
            WeaponChoice = WeaponChoice;

            switch (CharacterName.ToString())
            {
                case "PawKC":
                    HitChance += 5;
                    break;
                case "Robuck":
                    HitChance += 5;
                    break;
                case Name.CaptainPrice:
                    HitChance += 15;
                    break;
                case Name.AlexMason:
                    HitChance += 10;
                    break;
                case Name.Ghost:
                    HitChance += 5;
                    break;
                case Name.GeneralShepherd:
                    HitChance += 10;
                    break;
                case Name.CaptainWoods:
                    HitChance += 10;
                    break;
                default:
                    break;
            }
        }

        public override string ToString()
        {
            string description = "";

            switch (CharacterName)
            {
                case Name.PawKC:
                    description = "Game changer, but can't clutch one on one.";
                    break;
                case Name.Robuck:
                    description = "Biggest trash talker of the lobby.";
                    break;
                case Name.CaptainPrice:
                    description = "Leader of the group, wears a magnigicent Hat, with the best beard of all time.";
                    break;
                case Name.AlexMason:
                    description = "Extremely skilled fighter, brings his group back from the brink more likely than not.";
                    break;
                case Name.Ghost:
                    description = "Unkown member wearing an iconic black mask with a white skull.";
                    break;
                case Name.GeneralShepherd:
                    description = "Backstabber, will do anything to win!";
                    break;
                case Name.CaptainWoods:
                    description = "Resiliant, and won't quit until the job is done. Will sacrifice himself if need be.";
                    break;
                default:
                    break;
            }

            return string.Format("**** {0} ****\nLife: {1} of {2}\nHit Chance: {3}%\nWeapon:\n{4}\nEvade: {5}\nDescription: {6}",
                Name,
                Life,
                MaxLife,
                CalcHitChance(),
                WeaponChoice,
                Evade,
                description);
        }

        public override int CalcDamage()
        {
            Random rand = new Random();
            int damage = rand.Next(WeaponChoice.MinDamage, WeaponChoice.MaxDamage + 1);
            return damage;
        }

        public override int CalcHitChance()
        {
            return base.CalcHitChance() + WeaponChoice.BonusHitChance;
        }

    }
}
