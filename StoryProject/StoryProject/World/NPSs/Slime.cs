using StoryProject.World.Interfaces;
using StoryProject.World.WorldElements;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoryProject.World.NPSs
{
    class Slime : BaseUnit
    {

        private int _health;
        private int _damage;

        public override string Name { get; }
        public override int Health => _health;
        public override int Damage { get; }

        public Slime(string name = "Slime", int health = 25, int damage = 5)
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
        public override void GetDamage(int value) => Console.WriteLine($"the {Name} has damage resistance!");
    }
}
