namespace MyDungeonLibrary
{
    public class Player : Character
    {
        //my properties
        public string Description { get; set; }
        public Race PlayerRace { get; set; }
        public Weapon EquippedWeapon { get; set; }
        public int Score { get; set; }


        //Constructor
        public Player(string name, string description, int hitChance, int block, int health, Race playerRace, Weapon equippedWeapon, int score) : base(name, hitChance, block, health)
        {
            PlayerRace = playerRace;
            EquippedWeapon = equippedWeapon;
            Score = score;

            switch (PlayerRace)
            {
                case Race.Aasimar:
                    HitChance += 5;
                    break;
                case Race.Celadrin:
                    Block += 5;
                    break;
                case Race.Gattsu:
                    Health += 5;
                    break;
                case Race.Feyri:
                    HitChance += 3;
                    Block += 2;
                    break;
                case Race.Tiefling:
                    Health += 3;
                    HitChance += 2;
                    break;
                case Race.Demon:
                    HitChance += 5;
                    Block += 5;
                    break;
                default:
                    break;
            }
        }
        //Methods
        public override string ToString()
        {
            string raceDescription = "";
            switch (PlayerRace)
            {
                case Race.Aasimar:
                    raceDescription = "planetouched humanoids with celestial heritage and power.";
                    break;
                case Race.Celadrin:
                    raceDescription = "celestial elves with frail constitutions, but remarkable speed.";
                    break;
                case Race.Gattsu:
                    raceDescription = "humanoids descended from Goliaths and shades.";
                    break;
                case Race.Feyri:
                    raceDescription = "hybrid super creatures genetically engineered from inbreeding sun elves and depraved fiends.";
                    break;
                case Race.Tiefling:
                    raceDescription = "humanoid devils with enormous ram's horns, reptilian tales, and serpentine tongues.";
                    break;
                default:
                    break;
            }
            //add the weapon and the description to the base.ToString()
            return base.ToString() + $"Hunting with: {EquippedWeapon}\n" +
                                     $"{PlayerRace} are {raceDescription} \n" +
                                     $"{Name} has annihilated {Score} demon(s)";


        }//end ToString()

        //override CalcHitChance/CalcDamage... 
        public override int CalcDamage()
        {
            //create the return object
            int result;
            //setup necessary resources
            Random rand = new Random();
            //modify the return object
            int minDamage = EquippedWeapon.MinDamage;
            int maxDamage = EquippedWeapon.MaxDamage;
            if (EquippedWeapon.Type == WeaponType.Bastard_Sword && PlayerRace == Race.Aasimar)
            {
                minDamage += 3;
                maxDamage += 5;
            }
            result = rand.Next(minDamage, maxDamage + 1);
            //return the return object
            return result;

            //return new Random().Next(EquippedWeapon.MinDamage, EquippedWeapon.MaxDamage + 1);
        }

        public override int CalcHitChance()
        {
            return HitChance + EquippedWeapon.BonusHitChance;
        }

    }
}//end NameSpace



