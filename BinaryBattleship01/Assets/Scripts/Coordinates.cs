using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Coordinates : MonoBehaviour {

    public float countdownTimer = 92;
    public Text timerText;

    // Use this for initialization
    void Start()
    {

        timerText = GetComponent<Text>();

    }

    // Update is called once per frame
    void Update()
    {

        timerText.text = "x - 01";

    }
}