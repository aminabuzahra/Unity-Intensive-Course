using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Lecture45
{
    public class GotoLevel1 : MonoBehaviour
    {
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.C))
            {
                SceneManager.LoadScene("Level 1");
            }

        }
    }
}
