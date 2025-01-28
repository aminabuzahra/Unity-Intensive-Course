using UnityEngine;

namespace Assignment13
{
    public class GameManager : MonoBehaviour
    {
        void Start()
        {
            Player player1 = new Player();
            Player player2 = new Player();

            player1.InitializePlayer("Joha", 110);    // Edge Cases
            player2.InitializePlayer("Dokmeh", -10);  // Edge Cases

            player2.Heal(10);
            Debug.Log("Health of Player 2 is :" + player2.health);

            player2.Heal(true);
            Debug.Log("Health of Player 2 is :" + player2.health);

            Player.ShowPlayerCount();
        }
    }
}
