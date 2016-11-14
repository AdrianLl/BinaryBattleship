using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameBehaviourScript : MonoBehaviour {

	public void OnScan(){
		Scene scene = SceneManager.GetActiveScene ();
		if (scene.name == "02 - Game")
			Debug.Log ("You did it");
	}
}
