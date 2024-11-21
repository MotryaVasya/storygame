using StoryProject.World.Interfaces;

namespace StoryProject.World.WorldElements
{
    public class Trophy : IItem
    {
        public int Id { get; }
        public string Name { get; }
        public bool Unique { get; }
        public int Price { get; }
        public Trophy(int id, string name,int price, bool unique)
        {
            Id = id;
            Name = name;
            Price = price;
            Unique = unique;
        }
    }
}
