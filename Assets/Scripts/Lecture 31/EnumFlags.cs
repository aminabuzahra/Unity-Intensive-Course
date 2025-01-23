using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lecture31
{
    public class EnumFlags : MonoBehaviour
    {
        public PlayerStates player = PlayerStates.running | PlayerStates.crouching | PlayerStates.fighting;  // 1 1000
        private void Start()
        {
            Debug.Log(player);
        }
    }

    [System.Flags]
    public enum PlayerStates
    {
        idle = 1 << 0,       //  0001
        walking = 1 << 1,    //  0010
        jumping = 1 << 2,    //  0100 
        crouching = 1 << 3, //   1000
        running = 1 << 4,    // 1 0000
        fighting = 1 << 5,
        crf = 1 << 6

    }
}