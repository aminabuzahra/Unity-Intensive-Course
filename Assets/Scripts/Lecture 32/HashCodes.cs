using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lecture32
{
    public class HashCodes : MonoBehaviour
    {
        void Start()
        {
            // ProjectRhombus pr = new ProjectRhombus(true, false, false, false, 1, 1, 0);
            // ProjectRhombus pr2 = new ProjectRhombus(true, false, false, false, 1, 1, 0);
            // Debug.Log(pr.Equals(pr2));
            // Debug.Log(pr);
            // Debug.Log(pr.GetHashCode());
            // Debug.Log(pr2.GetHashCode());

            Player player = new(1, "Raed");
            Player player2 = new(2, "Subhi");
            Debug.Log(player); // ToString()
            Debug.Log(player.Equals(player2));
            Debug.Log(player.GetHashCode());

            Dictionary<Player, int> playersScores = new();
            playersScores.Add(player, 100);
            playersScores.Add(player2, 10);

            foreach (var score in playersScores)
            {
                Debug.Log(score);
            }

            Debug.Log(playersScores.ContainsKey(player));

        }
    }

    public class ProjectRhombus  // Inherits from Object
    {
        int id;
        int level;
        int score;
        bool right;
        bool up;
        bool down;
        bool left;

        public ProjectRhombus(bool right, bool up, bool down, bool left, int id, int level, int score)
        {
            this.right = right;
            this.up = up;
            this.down = down;
            this.left = left;
            this.id = id;
            this.level = level;
            this.score = score;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(id, level, score, up);
        }

        public override bool Equals(object obj)
        {
            ProjectRhombus temp = obj as ProjectRhombus;
            // ProjectRhombus temp = (ProjectRhombus)obj;
            return (
            (right == temp.right) &&
            (up == temp.up) &&
            (down == temp.down) &&
            (left == temp.left) &&
            (id == temp.id) &&
            (level == temp.level) &&
            (score == temp.score)
            );
        }

        public override string ToString()
        {
            return
            (
            right + ", " +
            up + ", " +
            down + ", " +
            left + ", " +
            id + ", " +
            level + ", " +
            score
            );
        }
    }


    public class Player
    {
        int id;
        string name;


        public Player(int id, string name)
        {
            this.id = id;
            this.name = name;

        }

        public override int GetHashCode()
        {
            return HashCode.Combine(id, name);
        }

        public override bool Equals(object obj)
        {
            Player temp = obj as Player;
            return (id == temp.id) && (name == temp.name);
        }

        public override string ToString()
        {
            return id + ", " + name;
        }
    }
}