using UnityEngine;

namespace Soccer
{
    public class SoccerPlayer : MonoBehaviour
    {
        public string Team;

        private GameManager _manager;

        void Start()
        {
            try 
            {
                _manager = FindObjectOfType<GameManager>();
                _manager.RegisterPlayer(this, Team);
            }
            catch
            {
                Debug.LogError("There must a GameManager component in a scene with soccer players!", this);
            }
        }
    }
}