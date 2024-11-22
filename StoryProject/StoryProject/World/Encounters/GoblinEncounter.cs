using StoryProject.Scenaries.Utils;
using StoryProject.World.NPSs;
using StoryProject.World.Player;
using StoryProject.World.WorldElements;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
namespace StoryProject.World.Encounters
{
    class GoblinEncounter : Encounter
    {
        private static Random rnd = new Random();

        public override Hero player { get; }
        public override Story storyEvent { get; }
        public override BaseUnit enemy { get; }
        public override Trophy trophy { get; }
        public override Achievement achievement { get; }
        public GoblinEncounter(Hero player, Story storyEvent)
        {
            this.player = player;
            this.storyEvent = storyEvent;
            enemy = new Goblin();
            trophy = null;
            achievement = null;
        }
        public override void Battle()
        {
            while (player.Health > 0 && enemy.Health > 0)
            {
                if (rnd.Next(1, 100) > 50) player.Attack(enemy);
                if (rnd.Next(1, 100) > 50) enemy.Attack(player);
            }
            if (player.Health > 0) player.Heal(rnd.Next(10, 100));
        }

        public override States Start() => storyEvent.Teller();
    }
}
