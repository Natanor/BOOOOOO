using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Soccer
{
    public class GameManager : MonoBehaviour
    {
        #region GameManager properties

        [SerializeField] private Dictionary<string, TeamInfo> _teams;
        [SerializeField] private GameObject _ball;

        private Vector3 _ballStartupPosition;

        #endregion

        #region Engine methods

        private void Start()
        {
            _teams = new();
            _ballStartupPosition = GetBallPosition();
        }

        #endregion

        #region GameManager methods

        public void RegisterPlayer(SoccerPlayer player, string team)
        {
            if (!_teams.ContainsKey(team))
                _teams.Add(team, new TeamInfo());

            _teams[team].Players.Add(player);
        }

        public TeamInfo GetTeamInfo(string teamName)
        {
            if (_teams.TryGetValue(teamName, out TeamInfo teamInfo))
                return teamInfo;

            return new();
        }

        public IEnumerable<string> GetTeamNames() => _teams.Keys;

        public Vector3 GetBallPosition() => _ball.transform.position;

        #endregion
    }
}
