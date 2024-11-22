using StoryProject.World.Interfaces;
using StoryProject.World.WorldElements;
using System;
using System.Runtime.InteropServices;
namespace StoryProject.World.Player
{
    public class Hero : BaseUnit
    {
        private int _health;
        private int _maxHealth;
        public override int Health => _health;

        public override string Name { get; }

        public override int Damage { get; }
        public Hero(int helth = 100, string name = "Hero", int damage = 15)
        {
            _health = helth;
            Name = name;
            Damage = damage;
        }
        public override void Attack(IUnit enemy)
        {
            Console.WriteLine($"{Name} attaked by sword");
            enemy.GetDamage(Damage);
        }

        public override void GetDamage(int damage)
        {
            _health -= damage;
            if (_health < 0) _health = 0;
            Console.WriteLine($"{Name} get {damage} damage");
        }
        public void Heal(int value)
        {
            int sumHealth = 0;        
            sumHealth = _health + value; // 60 50

            if (sumHealth > _maxHealth)
            {
                Console.WriteLine($"{Name} recover {_maxHealth - _health} health");
                _health = _maxHealth;
                Console.WriteLine($"{Name} have maximum health");

            }
            if (sumHealth < _maxHealth)
            {
                Console.WriteLine($"{Name} recover {value} health");
                _health += value;
            }
            if (_health <= 0)
            {
                Console.WriteLine($"{Name} is die");
            }

        }
    }
}

