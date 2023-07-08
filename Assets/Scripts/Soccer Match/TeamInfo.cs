using System.Collections.Generic;
using UnityEngine;

namespace Soccer
{
    [System.Serializable]
    public class TeamInfo
    {
        public List<SoccerPlayer> Players;
        public int Score;
    }
}