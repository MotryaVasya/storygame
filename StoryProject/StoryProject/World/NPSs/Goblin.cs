using StoryProject.World.Interfaces;
using StoryProject.World.WorldElements;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
namespace StoryProject.World.NPSs
{
    class Goblin : BaseUnit
    {
        private int _health;
        private int _damage;
        public override string Name { get; }

        public override int Health => _health;

        public override int Damage { get; }
        public Goblin(string name = "Goblin", int health = 40, int damage = 30)
        {
            Name = name;
            _health = health;
            Damage = damage;
        }
        public override void Attack(IUnit enemy)
        {
            Console.WriteLine($"{Name} attacked {enemy.Name} baton!");
            enemy.GetDamage(Damage);
        }
        public override void GetDamage(int value)
        {
            Console.WriteLine($"{Name} get {Damage} damages");
            _health -= value;
            if (_health < 0) _health = 0;
        }
    }
}
