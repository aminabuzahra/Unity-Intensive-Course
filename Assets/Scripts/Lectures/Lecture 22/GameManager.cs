using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

namespace Lecture22
{
    public class GameManager : MonoBehaviour
    {
        Player player;
        UIDisplay uIDisplay;

        void OnEnable()
        {
            player = new Player();
            uIDisplay = new UIDisplay();
            player.handleScoreChanged += uIDisplay.DisplayScoreUI; // Subscription


        }

        void Start()
        {
        }

        void Update()
        {
            if (Input.GetKeyUp(KeyCode.Space))
            {
                player.ChangeScore(1);
            }
        }

        void OnDisable()
        {
            player.handleScoreChanged -= uIDisplay.DisplayScoreUI; // Unsubscription
        }
    }

    public delegate void HandleScoreChanged(int i);

    public class Player
    {
        public int score = 0;

        public event HandleScoreChanged handleScoreChanged;

        public void ChangeScore(int amount)
        {
            score += amount;
            handleScoreChanged?.Invoke(score);
        }
    }

    public class UIDisplay
    {
        public void DisplayScoreUI(int score) => Debug.Log($"The score of the Subhi is : {score}");

    }
}
