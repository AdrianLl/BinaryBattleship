using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SettingsController : MonoBehaviour {

    public void togglePanel(GameObject panel)
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
