using StoryProject.World.Interfaces;
using StoryProject.World.WorldElements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoryProject.Scenaries.Utils
{
    class StoryLoader : SL_Service<Story>
    {
        public string Path => "C:\\Users\\STUDENT\\Desktop\\StoryProject\\StoryProject\\Data\\";
        protected override Story CreateObjectFromData(string[] data)
        {
            List<string[]> strings = new List<string[]>();
            foreach (string item in data) 
            {
                var row = item.Split(SptChar);
                strings.Add(row);
            }
            return new Story(strings);
        }

        protected override string[] GetDataFromObject(Story data)
        {
            string[] strings = new string[100];


            return strings;
        }
    }
}
