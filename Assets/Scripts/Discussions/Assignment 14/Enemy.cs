namespace Assignment14
{
    public class Enemy : Character
    {
        public Enemy(string enemyName, int enemyHealth) : base(enemyName, enemyHealth)
        {
        }

        public void Attack(Character other, int amount)
        {
            other.Health -= amount;
        }
    }
}
