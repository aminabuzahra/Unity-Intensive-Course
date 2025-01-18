using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lecture30
{
    public class BistwiseExamples : MonoBehaviour
    {
        // | = OR
        // 0 | 0 = 0
        // 0 | 1 = 1
        // 1 | 0 = 1
        // 1 | 1 = 1
        // اذا اردنا ان نضيف اكثر من معلومة في آن واحد

        // & = AND
        // 0 & 0 = 0
        // 0 & 1 = 0
        // 1 & 0 = 0
        // 1 & 1 = 1
        // إذا أردنا أن نفلتر معلومة من المعلومات في آن واحد

        // ^ XOR
        // 0 ^ 0 = 0
        // 0 ^ 1 = 1
        // 1 ^ 0 = 1
        // 1 ^ 1 = 0

        // << Left bit shift

        // >> Right bit shift

        // ~ not
        // ~0 = 1
        // ~1 = 0


        void Start()
        {
            Rigidbody rb = GetComponent<Rigidbody>();
            int mask = 253;
            rb.constraints = RigidbodyConstraints.FreezeRotationY | RigidbodyConstraints.FreezeRotationZ | RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionY | RigidbodyConstraints.FreezePositionZ;  // 0111 1110 
            Debug.Log(((int)rb.constraints) & mask);

            int bits = 1;
            bits = bits << 3;
            // bits <<= 3;
            Debug.Log(bits); // 2 * 2 * 2

            bits = bits >> 3;
            // bits >>= 3;
            Debug.Log(bits); // 2 / 2 / 2

            int a = 1;
            int b = 2;
            Debug.Log(a ^ b);

            int num1 = 35;
            int num2 = 40;

            // int temp = num1;
            // num1 = num2;
            // num2 = temp;

            num1 = num1 ^ num2;
            num2 = num1 ^ num2;
            num1 = num1 ^ num2;

            // (num1, num2) = (num2, num1);
            Debug.Log($"Num1 = {num1}, Num2 = {num2}");


            int password1 = 1234;
            int password2 = 0000;

            int key = 5214;

            int encryptedPassword1 = password1 ^ key;
            int encryptedPassword2 = password2 ^ key;

            Debug.Log(encryptedPassword1);
            Debug.Log(encryptedPassword2);

            int nPass1 = encryptedPassword1 ^ key;
            int nPass2 = encryptedPassword2 ^ key;

            Debug.Log(nPass1);
            Debug.Log(nPass2);

            Debug.Log(~(-16));
        }
    }
}
