using UnityEngine;

namespace Assignment13
{
    public class Player
    {
        public string playerName;
        public int health;

        static int playerCount = 0;  // private 

        public void InitializePlayer(string name, int initialHealth)
        {
            this.playerName = name;
            this.health = Mathf.Clamp(initialHealth, 0, 100);

            /*
            this.health = initialHealth;

            if (health > 100)
            {
                health = 100;
            }
            else if (health < 0)
            {
                health = 0;
            }
            */

            playerCount++;
        }

        public void Heal(int amount)
        {

            health = Mathf.Clamp(health + amount, 0, 100);

            // if (health > 100)
            // {
            //     health = 100;
            // }

            Debug.Log("Called from Heal Method. The new health is: " + health);
        }
        public void Heal(bool fullRestore)
        {
            if (fullRestore)
            {
                health = 100;
            }
        }

        public static void ShowPlayerCount()
        {
            Debug.Log("Player count is: " + playerCount);
        }
    }
}
