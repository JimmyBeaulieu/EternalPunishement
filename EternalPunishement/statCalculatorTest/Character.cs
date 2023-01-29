using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace statCalculatorTest
{
    internal class Character
    {
        //hard stats
        private string name;
        private int level;
        private int experience;
        private double strength;
        private double dexterity;
        private double constitution;
        private double sharpness;
        private double mindfulness;
        private double agility;
        //soft stats
        private double maxHP;//(Strength * 1.2) + (Constitution * 1.5) + (Agility * 1.1) + (Dexterity * 1.2)
        private double currentHP;
        private double maxEquipLoad;//((Strength * 1.7) + (Constitution * 1.3))
        private double lightWeaponEfficiency;
        private double heavyWeaponEfficiency;
        private double magicResistance;
        private double physicalResistance;
        //volatile stats
        public double damage;
        public bool criticalHit;


        public Character()
        {
            Name = null;
            Level = 1;
            Strength = 1;
            Dexterity = 1;
            Constitution = 1;
            Sharpness = 1;
            Mindfulness = 1;
            Agility = 1;
            statCalculation();
            //MaxHP =1;
            //MaxEquipLoad =1;
            //LightWeaponEfficiency = 1;
            //HeavyWeaponEfficiency = 1;
            //MagicResistance = 1;
            //physicalResistance = 1;
            damage = 0;

        }

        public string Name { get; set; }
        public int Level { get; set; }
        public int Experience { get; set; }
        //hard stats
        public double Strength { get; set; }
        public double Dexterity { get; set; }
        public double Constitution { get; set; }
        public double Sharpness { get; set; }
        public double Mindfulness { get; set; }
        public double Agility { get; set; }
        //soft stats
        public double MaxHP { get; set; }
        public double CurrentHP { get; set; }
        public double MaxEquipLoad { get; set; }
        public double LightWeaponEfficiency { get; set; }
        public double HeavyWeaponEfficiency { get; set;  }
        public double MagicResistance { get; set;  }
        public double PhysicalResistance { get; set;  }


       //public string RandomName()
       // {
       //     string[] name = { "Clem", "Davidson", "Drew", "Moore", "Kris", "Pearson", "Ashley", "Kennedy", "Alexis", "Hart", "Vic", "Moses", "Alex", "Haney", "Lesley", "Brennan", "Lynn", "Mckay", "Jody", "Moss" };
       //     Random random = new Random();
       //     return name[random.Next(name.Length)];
       // }
        public string StatSheet()
        {
            return "Your name:" + Name +"\nYour level:"+Level+"Your current experience:"+experience+ "/100\nYour strength:" + Strength + "\nYour dexterity:" + Dexterity + "\nYour constitution:" + Constitution + "\nYour sharpness:" + Sharpness + "\nYour mindfulness:" + Mindfulness + "\nYour agility:" + Agility + "\nYour max HP:" + MaxHP +"\nCurrent HP:"+CurrentHP+ "\nYour max equip load:" + MaxEquipLoad + "\nYour light weapon efficiency" + LightWeaponEfficiency + "\nYour heavy weapon efficiency:" + HeavyWeaponEfficiency + "\nYour magic resistance:" + MagicResistance + "\nYour physical resistance:" + PhysicalResistance;
        }
        public string Save()
        {
            return 
                  Name + "|"
                + Level + "|"
                + experience + "|"
                + Strength + "|"
                + Dexterity + "|"
                + Constitution + "|"
                + Sharpness + "|"
                + Mindfulness + "|"
                + Agility + "|"
                + MaxHP + "|"
                + CurrentHP + "|"
                + MaxEquipLoad + "|"
                + LightWeaponEfficiency + "|"
                + HeavyWeaponEfficiency + "|"
                + MagicResistance + "|"
                + PhysicalResistance+"|";
        }
        public void statCalculation()
        {
            Level =Convert.ToInt32(Strength + Dexterity + Constitution+Sharpness+Mindfulness+Agility);
            MaxHP = (((Strength * 1.2) + (Constitution * 1.5) + (Agility * 1.1) + (Dexterity * 1.2))*2);
            CurrentHP = MaxHP;
            MaxEquipLoad = ((Strength * 1.7) + (Constitution * 1.3));
            LightWeaponEfficiency = ((Strength * 1.1) + (Dexterity * 1.5) + (Agility * 1.4));
            HeavyWeaponEfficiency = ((Strength * 1.5) + (Dexterity * 1.1) + (Constitution * 1.4));
            MagicResistance = ((Constitution * 1.1) + (Sharpness * 1.4) + (Mindfulness * 1.4) + (Agility * 1.1));
            PhysicalResistance = ((Constitution * 1.5) + (Sharpness * 1.2) + (Mindfulness * 1.1) + (Agility * 1.2));
        }
    }
}