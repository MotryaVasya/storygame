using StoryProject.Scenaries.Utils;
using StoryProject.World;
using StoryProject.World.Encounters;
using StoryProject.World.Player;
using StoryProject.World.WorldElements;
using System.Runtime.InteropServices;

namespace StoryProject
{
    public class GameLoop
    {
        private Hero _player;
        private Story _currentStory;
        private Encounter _currentEncounter;
        private StoryLoader _loader;

        public GameLoop()
        {
            _player = new Hero();
            _loader = new StoryLoader();
            _currentStory = _loader.Load(_loader.Path + "Goblin", ".dad");
            _currentEncounter = new GoblinEncounter(_player, _currentStory);
        }
        public void Start()
        {
            States state = _currentEncounter.Start();
        }
    }
}
