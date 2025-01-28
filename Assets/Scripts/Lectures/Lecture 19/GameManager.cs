using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lecture19
{

    public class GameManager : MonoBehaviour
    {
        public Player player;
        public Ahmad ahmad;

        void Start()
        {
            player.onHealthLoosed += GameOver;
            player.onHealthLoosed += ahmad.AhmadMethod;
        }

        public void GameOver()
        {
            Debug.Log("Game Over !!!");
        }
    }
}
