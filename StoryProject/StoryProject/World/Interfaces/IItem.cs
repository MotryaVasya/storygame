namespace StoryProject.World.Interfaces
{
    interface IItem
    {
        int Id { get; }
        string Name { get; }
        bool Unique { get; }
        int Price {  get; }
    }
}
