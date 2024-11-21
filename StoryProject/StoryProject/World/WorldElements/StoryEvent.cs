using StoryProject.Scenaries.Utils;
using StoryProject.World.Player;
using System;
using System.Collections.Generic;
using System.Data;

namespace StoryProject.World.WorldElements
{
    public class StoryEvent
    {
        public Action BattleBegun { get; set; }
        private Hero _player;
        private Encounter _encounter;
        private List<string[]> _data;
        public StoryEvent(List<string[]> data)
        {
            _data = new List<string[]>();
            _data = data;
        }
        public SceneState Teller(string Id = "100")
        {
            var title = _data[0];
            foreach (var item in _data)
            {
                if (item[0] == Id)
                {
                    title = item; break;
                }
            }
            if (title[2] == "1")
            {
                Console.WriteLine(title[1]);
                var index = _data.FindIndex(i => i == title);
                var choice = _data[index];
                Console.WriteLine(choice[1]);
                return (SceneState)int.Parse(title[2]);
            }
            else
            {
                Console.WriteLine(title[1]);
                var numOfOpts = int.Parse(title[2]);
                var index = _data.FindIndex(i => i == title);
                List<string[]> options = new List<string[]>();
                for (int i = index; i < index + numOfOpts; i++)
                {
                    Console.WriteLine(_data[i][1]);
                    options.Add(_data[i]);
                }
                int choice = PlayerChoice(options.Count);
                if (options[choice][2] == "2")
                {
                    if (_encounter.player.Health == 0)
                    {
                        return Teller("666");
                    }
                    //BattleBegun?.Invoke();
                }
                return Teller(options[choice][3]);
            }
        }
        private int PlayerChoice(int maxValue)
        {
            while (true)
            {
                var input = (int)Console.ReadKey().Key;
                if (input > 48 && input < 58)
                {
                    var value = input % 48;
                    if (value > 0 && value <= maxValue) return value;
                }
                else
                {
                    Console.WriteLine("повторите ввод");
                }
            }
        }
    }
}