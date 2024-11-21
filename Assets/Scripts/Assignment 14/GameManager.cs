using UnityEngine;

namespace Assignment14
{
    public class GameManager : MonoBehaviour
    {
        void Start()
        {
            Player player = new Player("Subhi", 80);
            Enemy enemy = new Enemy("Sharshabeel", 70);

            Debug.Log("Player name is : " + player.Name);
            Debug.Log("Player health is : " + player.Health);

            Debug.Log("enemy name is : " + enemy.Name);
            Debug.Log("Enemy health is : " + enemy.Health);

            player.Heal(10);
            Debug.Log("Player health is : " + player.Health);

            enemy.Attack(player, 100);
            Debug.Log("Player health is : " + player.Health);
        }
    }
}
