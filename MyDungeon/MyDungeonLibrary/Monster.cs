namespace MyDungeonLibrary
{
    public class Monster : Character
    {
        //unique fields:
        private int _minDamage;

        //unique props:
        public string Description { get; set; }
        public int CelestialBounty { get; set; }
        public Weapon EquippedWeapon { get; set; }
        public int MaxDamage { get; set; }
        public int MinDamage
        {
            get { return _minDamage; }
            //custom business rule, value must be greater than 0 and less than MaxDamage.
            set
            {
                if ((value > 0 && value < MaxDamage))
                {
                    _minDamage = value;
                }
                else
                {
                    _minDamage = 1;
                }
            }
            //set { _minDamage = (value > 0 && value < MaxDamage) ? value : 1; }     

        }
        public Monster(string name, string description, int hitChance, int block, int health, int celestialBounty, Weapon equippedWeapon)
            : base(name, hitChance, block, health)
        {
          
            Description = description;
            CelestialBounty = celestialBounty;
        }

        public Monster()
        {

        }

      

        public override string ToString()
        {
            return base.ToString() + $"Harvesting souls with: {EquippedWeapon}\n" +
                                     $"{Name} is {Description} \n" +
                                     $"{Name}'s Celestial Bounty is {CelestialBounty}";

        }
        public override int CalcDamage()
        {
            //throw new NotImplementedException();
            int result;//create the return object

            Random rand = new Random();//setup necessary resources

            result = rand.Next(MinDamage, MaxDamage + 1);//modify the return object

            return result;//return the return object
        }

        public static Monster GetMonster()
        {
            //public Monster(string name, string description, int hitChance, int block, int health, int celestialBounty, Weapon equippedWeapon)
            //create the return object
            Monster m = new();
            //setup necessary resources
            Monster m1 = new("Stavrogin", "Demon of Despair", 50, 20, 70, 3, "Nihilism", w6);
            Monster m2 = new("Pope Bacon X", "Demon of Pestilence", 50, 20, 70, 2, "Soul Harvester", w7);
            Monster m3 = new("Zarathustra", "Demon of Tyranny", 50, 20, 70, 5, "Apocalypse", w9);
            Monster m4 = new("Pynchon", "Demon of Suffering", 50, 20, 70, 2, "Red Scepter", w9);
            Monster m5 = new("Milton", "Demon of Hopelessness", 50, 20, 70, 8, "Death's Scythe", w10);
            List<Monster> monsters = new()
            {
                m1, m1, m1, m1, m1,//5/17
                m2, m2, m2,        //3/17
                m3, m3, m3, m3,    //4/17
                m4, m4, m4, m4,    //4/17
                m5                 //1/17
            };
            Random rand = new Random();
            int randomIndex = rand.Next(monsters.Count);
            //modify the return object
            m = monsters[randomIndex];
            //return the return object
            return m;

            //refactor
            //return monsters[new Random().Next(monsters.Count)];
        }



    }
}