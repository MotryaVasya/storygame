using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoryProject.World.WorldElements
{
    public abstract class Encounter
    {
        public StoryEvent storyEvent { get; }
        public NPC enemy {  get; }
        public Trophy trophy { get; }
        public Achievment achievment { get; }
        protected Encounter(StoryEvent newStoryEvent, NPC newEnemy, Trophy newTrophy, Achievment newAchievment)
        {
            storyEvent = newStoryEvent;
            enemy = newEnemy;
            trophy = newTrophy;
            achievment = newAchievment;
        }
    }
}
