using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lecture15
{
    public class EnumeratorsExample : MonoBehaviour
    {
        void Start()
        {
            // int character = 0;  // 0 - Stopping  1- Walking  2- Running  3- Jumping 

            // character = 1;

            // if (character == 1)
            // {
            //     Debug.Log("Character is walking");
            // }

            //
            //
            //
            //
            //
            //

            // character = 0;

            // if (character == 2)
            // {
            //     Debug.Log("Character is running");
            // }

            CharacterState character2 = CharacterState.Running;

            if (character2 == CharacterState.Stopping)
            {
                Debug.Log("Character2 is Stopping");
            }
            else if (character2 == CharacterState.Walking)
            {
                Debug.Log("Character2 is Walking");
            }
            else if (character2 == CharacterState.Running)
            {
                Debug.Log("Character2 is Running");
            }
            else if (character2 == CharacterState.Jumping)
            {
                Debug.Log("Character2 is Jumping");
            }
            else if (character2 == CharacterState.Shooting)
            {
                Debug.Log("Character2 is Shooting");
            }
            else if (character2 == CharacterState.Stabbing)
            {
                Debug.Log("Character2 is Stabbing");
            }
            else
            {
                Debug.Log("Any other state");
            }


            switch (character2)
            {
                case CharacterState.Stopping:
                    Debug.Log("Character2 is Stopping");
                    break;

                case CharacterState.Walking:
                    Debug.Log("Character2 is Walking");
                    break;

                case CharacterState.Running:
                    Debug.Log("Character2 is Running");
                    break;

                case CharacterState.Jumping:
                    Debug.Log("Character2 is Jumping");
                    break;

                case CharacterState.Shooting:
                    Debug.Log("Character2 is Shooting");
                    break;

                default:
                    Debug.Log("Any other state");
                    break;
            }
        }
    }
}

