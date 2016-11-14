using UnityEngine;
using System.Collections;

public class Panel : MonoBehaviour {

	public void TogglePanel (GameObject panel) {
		panel.SetActive (!panel.activeSelf);
	}
	

}
