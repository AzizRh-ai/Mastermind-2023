using System;
using UnityEngine;

public class Code : MonoBehaviour
{
    public int[] secretCode;
    public void OnButtonTrigger()
    {
        combinaison();
    }
    public int[] codeGenerator()
    {
        int[] secret = new int[4];
        System.Random rnd = new System.Random();
        for (int i = 0; i < secret.Length; i++)
        {
            secret[i] = rnd.Next(6);
        }
        secretCode = secret;
        return secretCode;
    }

    public int[] combinaison()
    {
        if (secretCode == null)
        {
            return codeGenerator();
        }
        else
        {
            foreach (int i in secretCode)
            {
                Debug.Log("secretCode:" + String.Join(",", i));
            }
            return secretCode;
        }
    }
}
