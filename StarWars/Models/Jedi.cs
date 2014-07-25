using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StarWars.Models
{
    public class Jedi: Character
    {
        public string SaberColor;
        public Jedi (string name, string race, string sabercolor)
        {
            Name = name;
            Race = race;
            SaberColor = sabercolor;
            MyType = Character.Type.Jedi;
        }
    }
}