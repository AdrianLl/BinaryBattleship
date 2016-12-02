using UnityEngine;
using System.Collections;

public class PanelBehaviour : MonoBehaviour {


    public void TogglePanel(GameObject panel)
    {
        panel.SetActive(!panel.activeSelf);
    }

    // Use this for initialization
    void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
