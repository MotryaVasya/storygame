using StoryProject.Scenaries.Utils;
using StoryProject.World.Player;
using StoryProject.World.WorldElements;
using System;

namespace StoryProject.World
{
    public abstract class Encounter
    {
        public abstract Story storyEvent { get; }
        public abstract Hero player { get; }
        public abstract BaseUnit enemy { get; }
        public abstract Trophy trophy { get; }
        public abstract Achievement achievement { get; }
        public abstract void Battle();
        public abstract States Start();
    }
}
