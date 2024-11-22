using StoryProject.World.Interfaces;

namespace StoryProject.World.WorldElements
{
    public abstract class BaseUnit : IUnit
    {
        public abstract string Name { get; }
        public abstract int Health { get; }
        public abstract int Damage { get; }

        public abstract void Attack(IUnit enemy);

        public abstract void GetDamage(int value);
    }
}
