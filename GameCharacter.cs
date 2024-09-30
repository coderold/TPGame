using System;

namespace TPGame
{
    public class GameCharacter
    {
        public struct INFO
        {
            public string name;
            public int level;
        }

        public struct STATS
        {
            public int Strength;
            public int Agility;
            public int Vitality;
            public int Intelligence;
            public int Dexterity;
            public int Luck;
        }

        public struct PROFESSION
        {
            public string profession;
        }

    }
}