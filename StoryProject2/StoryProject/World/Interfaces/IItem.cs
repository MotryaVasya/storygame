using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoryProject.World.Interfaces
{
    interface IItem
    {
        int Id { get; }
        string Name { get; }
        bool Unique { get; }
    }
}
