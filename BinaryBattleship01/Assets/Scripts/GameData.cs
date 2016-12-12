using UnityEngine;
using System.Collections;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System;
using System.Linq;


public class GameData : MonoBehaviour
{
    public string playerNameInput;
    public int score;
    public AudioMixerSnapshot menuMusic;
    public AudioMixerSnapshot gameMusic;
    private float transTime = 0.8f;

    public static GameData Instance;
    //public InputField playerName;

    void Start()
    {
        playerNameInput = "";
        score = 0;

        
    }

    void Update()
    {
        if (SceneManager.GetActiveScene().name == "02 - Game")
        {
            gameMusic.TransitionTo(transTime);
        }
        else
        {
            menuMusic.TransitionTo(0);
        }
    }

    void Awake()
    {
        if (Instance == null)
        {
            DontDestroyOnLoad(gameObject);
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void setScore(int s)
    {
        score = s;
    }

    public int getScore()
    {
        return score;
    }

    public void increaseScore(int a)
    {
        score += a;
    }
    /*
    public void setName(InputField n)
    {
        pName = GameObject.FindWithTag("NameInputField").GetComponent<InputField>();
        playerName = Convert.ToString(pName.text);
        Debug.Log(playerName + "NAME WORKS!");
    }
    */

    public void setName(string n)
    {
        playerNameInput = n;
    }
    public string getName()
    {
        return playerNameInput;
    }
}
