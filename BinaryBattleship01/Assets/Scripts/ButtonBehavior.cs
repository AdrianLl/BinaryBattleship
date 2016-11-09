using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ButtonBehavior : MonoBehaviour {

    public void PlayGame()
    {
        SceneManager.LoadScene("02Game");
    }

    public void GoToDirections()
    {
        SceneManager.LoadScene("settings");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
