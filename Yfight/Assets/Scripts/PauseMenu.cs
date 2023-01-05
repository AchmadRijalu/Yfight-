using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{

    public GameObject pauseMenu;
    public  bool isPaused = false;
    // Start is called before the first frame update
    void Start()
    {
        // pauseMenu.setActive(false);
        isPaused = false;
}

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            setGameState();
        }
    } 

    public void PauseGame()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0;
        isPaused = true;
    }

    public void ResumeGame()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1;
        isPaused = false;
    }

    public void setGameState()
    {
        if(isPaused)
        {
            isPaused = false;
            ResumeGame();
        }
        else
        {
            isPaused = true;
            PauseGame();
        }
    }
}
