using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PauseMenu : MonoBehaviour
{
    private void Start()
    {
        GetComponent<Canvas>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
       if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(Time.timeScale != 0)
            {
                //pause the game
                PauseGame();
            }
            else
            {
                //resume the game
                resume();
            }
        }
    }
    public void PauseGame()
    {
        Time.timeScale = 0;
        GetComponent<Canvas>().enabled = true;
    }
    public void resume()
    {
        //resume the game,unpause
        Time.timeScale = 1;
        GetComponent<Canvas>().enabled = false;

    }
    public void restart()
    {
        Time.timeScale = 1;
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name);
    }
    public void mainmenu()
    {
        SceneManager.LoadScene("mainmenu");
    }
    public void Quit()
    {
        Application.Quit();
    }
}
