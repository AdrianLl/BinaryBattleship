﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DataDisplay : MonoBehaviour
{

    private Text timerText;

    // Use this for initialization
    void Start()
    {

        timerText = GetComponent<Text>();

    }

    // Update is called once per frame
    void Update()
    {
        timerText.text = "Name: " + GameData.Instance.getName() +
            "\nScore: " + GameData.Instance.getScore()+
            "\nLevel: " + GameData.Instance.getLevel();




    }


}
