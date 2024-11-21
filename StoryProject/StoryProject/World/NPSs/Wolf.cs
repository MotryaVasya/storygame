using StoryProject.World.Interfaces;
using StoryProject.World.WorldElements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoryProject.World.NPSs
{
    class Wolf : NPC
    {
        private string _name;
        private int _health;
        private int _damage;
        public override string Name => _name;

        public override int Health => _health;

        public override int Damage => _damage;
        public Wolf(string name, int health, int damage)
        {
            _name = name;
            _health = health;
            _damage = damage;
        }
        public override void Attack(IUnit enemy)
        {
            Console.WriteLine($"{Name} attacked {enemy.Name} baton!");
            enemy.GetDamage(Damage);
            Console.WriteLine($"{enemy.Name} get {Damage} damages");
        }

        public override void GetDamage(int value)
        {
            _health -= value;
            if (_health <= 0) _health = 0;
        }
    }
}
