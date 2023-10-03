using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDungeonLibrary
{
    //! Make it public, make it a child of Monster, Rename it to whatever you want
    public class MonsterTemplate : Monster
    {
        //FIELDS - only if you have business rules


        //PROPS
        //! Add at least one custom property. 

        //CTORS        
        public MonsterTemplate(string name, int hitChance, int block, int health, int maxDamage, int minDamage, string description, Weapon equippedWeapon) : base(name, hitChance, block, health, maxDamage, minDamage, description)
        {
            //! Add your custom prop(s) to the parameter list and assign them here.
        }

        //! Default CTOR (creates a basic version of this monster)
        public MonsterTemplate()
        {
            //Assign each of the props some default value here
            //Name, HitChance, Block, MaxLife, MaxDamage, MinDamage, Description
        }

        public override string ToString()
        {
            //! Update the ToString() to include your new prop
            return base.ToString() + "";
        }

        //Override at least one parent method to change the functionality based on your custom prop
        //CalcBlock()
        //CalcHitChance()
        //CalcDamage()
    }
}
//new Random().Next(1, 100) <= 5;

//after we create our own monsters, we can fill in the "unnamed" monsters, like m1, m2, m3, etc. in 