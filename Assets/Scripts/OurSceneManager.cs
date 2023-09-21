using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OurSceneManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject MainGame;
    public void StartGame()
    {
        SceneManager.LoadScene("Game");

    }
}
