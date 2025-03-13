using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Lecture45
{
    public class GotoLevel2 : MonoBehaviour
    {
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.C))
            {
                SceneManager.LoadScene("Level 2", LoadSceneMode.Additive);
            }

        }
    }
}
