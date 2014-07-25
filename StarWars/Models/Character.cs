using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StarWars.Models
{
    public class Character
    {
        public string Name;
        public string Race;
        public enum Type { Jedi, BountyHunter };
        public Type MyType;
    }
}