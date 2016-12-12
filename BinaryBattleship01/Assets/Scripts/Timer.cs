using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour {

    public float countdownTimer  = 60;
    public Text timerText;
    private GameStates gameStates;



    // Use this for initialization
    void Start () {

        timerText = GetComponent<Text>();

    }
	
	// Update is called once per frame
	void Update () {

        gameStates = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameStates>();

        if (gameStates.gameON)
        {
            countdownTimer -= Time.deltaTime;
            timerText.text = countdownTimer.ToString("f0");
                
			if(countdownTimer <= 0){SceneManager.LoadScene("04 - Gameover");}
        }
	
	}


}
