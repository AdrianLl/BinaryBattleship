using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System;
using System.Linq;


public class ButtonBehavior : MonoBehaviour {
	private InputField x;
	private InputField y;
    private InputField playerName;
	private string xy;
    private InputField playerInputField;


	void Awake(){
	//	x = GameObject.Find ("X Input").GetComponent<InputField> ();
	//	y = GameObject.Find ("Y Input").GetComponent<InputField> ();

	//	xy = "you entered "+ x.text + " " + y.text;
	}

    public void PlayGame()
    {
        SceneManager.LoadScene("02 - GameL2");
    }

    public void GoToDirections()
    {
        SceneManager.LoadScene("03 - Instructions");
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("01- Menu");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void Pregame()
    {
        SceneManager.LoadScene("05 - Pregame");
    }

	public void GetInput(string xy)
	{
		x = GameObject.Find ("X Input").GetComponent<InputField> ();
		y = GameObject.Find ("Y Input").GetComponent<InputField> ();

		xy = "you entered "+ x.text + " " + y.text;
		Debug.Log (xy);
	}

    public void setPlayerName()
    {
        playerInputField = GameObject.Find("PlayerNameInputField").GetComponent<InputField>();
        GameData.Instance.setName(playerInputField.text);
    }

    public void getNamePanel()
    {
        SceneManager.LoadScene("06 - NameInput");
    }

    public void MachineInstructions()
    {
        SceneManager.LoadScene("07 - MachineInstructions");
    }


    public void RestartGame()
    {
        SceneManager.LoadScene("02 - GameL2");
        GameData.Instance.setScore(0);
    }
}
