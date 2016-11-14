using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ButtonBehavior : MonoBehaviour {

    public void PlayGame()
    {
        SceneManager.LoadScene("02 - Game");
    }

    public void GoToDirections()
    {
        SceneManager.LoadScene("03 - Directions");
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("01- Menu");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
