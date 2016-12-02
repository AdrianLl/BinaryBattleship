using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Coordinates : MonoBehaviour {

    public Text timerText;
    private GameStates gameStates;

    // Use this for initialization
    void Start()
    {

        timerText = GetComponent<Text>();

    }

    // Update is called once per frame
    void Update()
    {
        gameStates = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameStates>();

        if (gameStates.gameON)
        {
            timerText.text =
                "X: 0010 \n" +
                "Y: 0010";
        }
        else
        {
            timerText.text = "Waiting for signals...";
        }

    }
}