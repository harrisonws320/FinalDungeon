namespace MyDungeonLibrary
{
    public class Weapon
    {
        //fields:
        private string _weaponName, _weaponDescription;
        private int _minDamage, _maxDamage, _criticalHitChance, _bonusHitChance;
        private WeaponType _type;

        //props:
        public string WeaponName { get { return _weaponName; } set { _weaponName = value; } }
        public string WeaponDescription { get { return _weaponDescription; } set { _weaponDescription = value; } }
        public int CriticalHitChance { get { return _criticalHitChance; } set { _criticalHitChance = value; } }
        public int BonusHitChance { get { return _bonusHitChance; } set { _bonusHitChance = value; } }
        public int MaxDamage { get { return _maxDamage; } set { _maxDamage = value; } }
        public int MinDamage
        {
            get { return _minDamage; }
            set
            {
                //business rule:
                //0 < MinDamage <= MaxDamage
                if (value > 0 && value <= MaxDamage)
                {
                    //good to go
                    _minDamage = value;
                }
                else
                {
                    _minDamage = 1;
                }
            }
        }
        public WeaponType Type { get { return _type; } set { _type = value; } }

        public Weapon(string weaponName, string weaponDescription, int minDamage, int maxDamage, int criticalHitChance, int bonusHitChance, WeaponType type)
        {
            if (minDamage > maxDamage)
            {
                Console.WriteLine("The weapon's minimum damage cannot exceed its maximum damage.");
            }

            WeaponName = weaponName;
            WeaponDescription = weaponDescription;
            MinDamage = minDamage;
            MaxDamage = maxDamage;
            CriticalHitChance = criticalHitChance;
            BonusHitChance = bonusHitChance;
            Type = type;
        }//fully qualified ctor
         //Method:
        public override string ToString()
        {

            string typeDescription = "";
            switch (Type)
            {

                case WeaponType.Bastard_Sword:
                    typeDescription = "Bastard Sword";
                    break;

                case WeaponType.Rapier:
                    typeDescription = "Rapier";
                    break;

                case WeaponType.Gattsu_Giant_Sword:
                    typeDescription = "Gattsu Giant Sword";
                    break;

                case WeaponType.Katana:
                    typeDescription = "Katana";
                    break;

                case WeaponType.Machete:
                    typeDescription = "Machete";
                    break;

                case WeaponType.Nodachi:
                    typeDescription = ":Nodachi";
                    break;

                case WeaponType.Sickle:
                    typeDescription = "Sickle";
                    break;

                case WeaponType.Warscythe:
                    typeDescription = "Warscythe";
                    break;

                case WeaponType.Morningstar:
                    typeDescription = "Morningstar";
                    break;
                case WeaponType.Scythe:
                    typeDescription = "Scythe";
                    break;
            }


            //return base.ToString();//namespace.classname
            return $"{WeaponName}:\n" +
                $"A {typeDescription}" +
                $"that {WeaponDescription}\n" +
           $"Damage: {MinDamage} to {MaxDamage}\n" +
           $"Critical Hit Chance: {CriticalHitChance}%\n" +
           $"Bonus Hit: {BonusHitChance}%\n";


        }
    }
}
