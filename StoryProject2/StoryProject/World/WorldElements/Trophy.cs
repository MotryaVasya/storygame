using StoryProject.World.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoryProject.World.WorldElements
{
    public class Trophy : IItem
    {
        public int Id { get; }

        public string Name {  get; }

        public bool Unique {  get; }

        public Trophy(int id, string name, bool unique)
        {
            Id = id;
            Name = name;
            Unique = unique;
        }
    }
}
