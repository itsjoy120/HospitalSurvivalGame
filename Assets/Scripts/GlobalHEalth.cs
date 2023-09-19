using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GlobalHEalth : MonoBehaviour
{
    public static int currentHP = 20;
    public int internalHP;
    void Update()
    {
        internalHP = currentHP;
        if (currentHP <= 0)
        {
            SceneManager.LoadScene(1);
        }
    }
}
