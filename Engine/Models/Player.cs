using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    class Player
    {
        public string Name { get; set; }
        public string CharacterClass { get; set; }
        public int HitPoints { get; set; }
        public int ExperiencePoints { get; set; }
        public int Level { get; set; }
        public int Gold { get; set; }
        public Player()
        {
            Name = "N/A";
            CharacterClass = "N/A";
            HitPoints = 10;
            ExperiencePoints = 0;
            Level = 1;
            Gold = 10;
        }
    }
}
