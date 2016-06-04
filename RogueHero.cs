using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hero4
{
    class Rogue
    {
        static void Main(string[] args)
        {
            Hero Rogue = new Hero("Rogue");
            Rogue.Show();
            Rogue.Fight();
        }
    }
    /**
     * This class describes a Rogue Class hero
     * 
     * @class Hero
     * */
    class Hero
    {
        private static Random _rng = new Random();

        private int _strength;
        private int _speed;
        private int _health;
        private string _name;
        /**
       *
       * 
       * @method Name
       * */
        // This passes the private _name property to the public Name property 
        public string Name
        {
            get { return _name; }
        }
        /**
       * constructs a hero 
       * 
       * @method Hero
       * */
        // This is a constructor method for generating a hero
        public Hero(string name)
        {
            _name = name;
            _generateAbilties();
        }
        /**
       * This method rolls random attributes for a Rogue
       * 
       * @method _generateAbilties
       * */
        private void _generateAbilties()
        {
            _strength = _rng.Next(20, 100);
            _speed = _rng.Next(30, 100);
            _health = _rng.Next(15, 100);
        }
        /**
       * This method rolls to hit internally
       * 
       * @method _hitAttempt
       * */
        private bool _hitAttempt()
        {
            int roll = _rng.Next(1, 100);
            return roll <= 20;
        }
        /**
       * This method rolls for damage
       * 
       * @method _hitDamage
       * */

        private int _hitDamage()
        {
            int roll = _rng.Next(1, 6);
            return roll * _strength;
        }
        /**
       * This method displays the results of the roll to hit method
       * 
       * @method Fight
       * */
        public void Fight()
        {
            if (_hitAttempt())
            {
                int damage = _hitDamage();
                Console.WriteLine(damage);
            }
            else
            {
                Console.WriteLine("Your attack missed");
            }

        }
        /**
       * Display's the hero's attributes and name in the console
       * 
       * @method Show
       * */

        public void Show()
        {
            Console.WriteLine(_name);
            Console.WriteLine("Health:   {0}", _health);
            Console.WriteLine("Speed:    {0}", _speed);
            Console.WriteLine("Strength: {0}", _strength);
        }
    }

}

