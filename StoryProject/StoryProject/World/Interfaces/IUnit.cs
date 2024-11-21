namespace StoryProject.World.Interfaces
{
    public interface IUnit
    {
        string Name { get; }
        int Health { get; }
        int Damage { get; }

        void Attack(IUnit enemy);
        void GetDamage(int value);
    }
}
