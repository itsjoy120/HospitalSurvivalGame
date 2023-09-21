using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OurSceneManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject MainGame;
    public GameObject PauseMenu;

    public void Start()
    {
        PauseMenu.SetActive(false);
    }
    public void StartGame()
    {

        SceneManager.LoadScene("Game");
        Time.timeScale = 1.0f;
    }

    public void Update()
    {

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            PauseMenu.SetActive(true);
            Time.timeScale = 0f;
            //Cursor.lockState = CursorLockMode.None;
            //Cursor.visible = true;
        }
        if(PauseMenu.activeSelf)
        {
            if (Input.GetKeyDown(KeyCode.Q))
            {
                Application.Quit();
            }

            if (Input.GetKeyDown(KeyCode.R))
            {
                PauseMenu.SetActive(false);
                Time.timeScale = 1.0f;
                SceneManager.LoadScene("Game");
            }
        }


    }

    public void Unpause()
    {
        PauseMenu.SetActive(false);
        Time.timeScale = 1.0f;
    }
    public void Quit()
    {
        Application.Quit();
    }
    
}
