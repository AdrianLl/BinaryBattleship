using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	public void OnSartGame(string sceneName)
	{
		Application.LoadLevel (sceneName);
	}

}
