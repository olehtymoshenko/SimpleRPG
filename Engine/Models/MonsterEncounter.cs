﻿namespace Engine.Models
{
    public class MonsterEncounter
    {
        public int MonsterID { get; set; }

        public int ChanceOfEncountering { get; set; }

        public MonsterEncounter(int monsterId, int chanceOfEncountering)
        {
            MonsterID = monsterId;
            ChanceOfEncountering = chanceOfEncountering;
        }

    }
}
