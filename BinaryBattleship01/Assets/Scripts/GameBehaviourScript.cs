using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameBehaviourScript : MonoBehaviour {
	public Panel obj;

	public void OnScan(){
		Scene scene = SceneManager.GetActiveScene ();
		if (scene.name == "02 - Game")
			Debug.Log ("You did it");
		    
		//obj.TogglePanel(GameObject panel);
	}
}
