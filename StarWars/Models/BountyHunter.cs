using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StarWars.Models
{
    public class BountyHunter: Character
    {
        public string Weapon;
        public BountyHunter(string name, string race, string weapon)
        {
            Name = name;
            Race = race;
            Weapon = weapon;
            MyType = Character.Type.BountyHunter;
        }
    }
}