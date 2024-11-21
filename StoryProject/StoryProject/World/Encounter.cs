using StoryProject.World.Player;
using StoryProject.World.WorldElements;
using System;

namespace StoryProject.World
{
    public class Encounter
    {
        public StoryEvent storyEvent { get; }
        public Hero player {  get; }
        public NPC enemy { get; }
        public Trophy trophy { get; }
        public Achievement achievement { get;}

        public Encounter(int StoryID, NPC newEnemy, Trophy newTrophy, Achievement newAchievement)
        {
            storyEvent = LoadStory(StoryID);
            enemy = newEnemy;
            trophy = newTrophy;
            achievement = newAchievement;
        }

        private StoryEvent LoadStory(int storyID)
        {

            return null;
        }
    }
}
