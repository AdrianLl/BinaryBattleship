using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class ButtonBehavior : MonoBehaviour {
	private InputField x;
	private InputField y;
	private string xy;


	void Awake(){
	//	x = GameObject.Find ("X Input").GetComponent<InputField> ();
	//	y = GameObject.Find ("Y Input").GetComponent<InputField> ();

	//	xy = "you entered "+ x.text + " " + y.text;
	}

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

    public void DisplayKey()
    {

    }

	public void GetInput(string xy)
	{
		x = GameObject.Find ("X Input").GetComponent<InputField> ();
		y = GameObject.Find ("Y Input").GetComponent<InputField> ();

		xy = "you entered "+ x.text + " " + y.text;
		Debug.Log (xy);
	}
}
