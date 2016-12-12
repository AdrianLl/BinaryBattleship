using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerNameDisplay : MonoBehaviour {

    private Text timerText;

    void Start()
    {

        timerText = GetComponent<Text>();

    }

    // Update is called once per frame
    void Update()
    {
        timerText.text = GameData.Instance.getName();



    }
}
