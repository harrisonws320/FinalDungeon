using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDungeonLibrary
{
    public abstract class Character
    //public parent-only class called Character
    {
        //fields:
        private string _name;
        private int _hitChance, _block, _health;

        //props:
        public string Name { get { return _name; } set { _name = value; } }
        public int HitChance { get { return _hitChance; } set { _hitChance = value; } }
        public int Block { get { return _block; } set { _block = value; } }
        public int Health { get { return _health; } set { _health = value; } }

        //ctors:
        public Character()
        {

        }
        public Character(string name, int hitChance, int block, int health)
        {
            Health = health;
            Block = block;
            HitChance = hitChance;
            Name = name;
        }

         public override string ToString()
        {
            //return base.ToString();
            return $"|---{Name}---|\n" +
                   $"Health: {Health}\n" +
                   $"Hit Chance: {HitChance}%\n" +
                   $"Parry: {Block}%\n";
        }

        //virtual keyword allows these methods to be overridden in child classes.
        public virtual int CalcBlock()
        {
            //can be overridden in your OWN monster subtypes.
            return Block;
        }
        public virtual int CalcHitChance()
        {
            return HitChance;
        }
        //any child classes MUST override abstract methods.
        //you can only define abstract methods inside of abstract classes.
        public abstract int CalcDamage();


    }//end class
}//end namespace
