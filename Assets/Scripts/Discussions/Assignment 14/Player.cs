namespace Assignment14
{
    public class Player : Character
    {
        public Player(string playerName, int playerHealth) : base(playerName, playerHealth)
        {
        }

        public void Heal(int amount)
        {
            Health += amount;
        }
    }
}
