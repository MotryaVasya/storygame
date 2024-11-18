﻿using StoryProject.World.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoryProject.World.WorldElements
{
    public abstract class NPC : IUnit
    {
        public abstract string Name { get; }
        public abstract int Health { get; }
        public abstract int Damage { get; }

        public abstract void Attack(IUnit enemy);
    }
}