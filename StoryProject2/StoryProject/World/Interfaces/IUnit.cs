using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoryProject.World.Interfaces
{
    public interface IUnit
    {
        string Name { get; }
        int Health { get; }
        int Damage { get; }

        void Attack (IUnit enemy);
    }
}
