using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class sceneSwitcher : MonoBehaviour
{
    public void nextScene() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }

    public void prevScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);

    }

    public void goToTutorial() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }
    public void toMenuFromTutorial()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);

    }


    public void quitGame()
    {
        Application.Quit();
        Debug.Log("Game is exiting");
    }

}
