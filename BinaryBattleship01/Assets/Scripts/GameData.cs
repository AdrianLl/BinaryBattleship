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
    public int level;
    private bool altSong = false;

    public AudioMixerSnapshot menuMusic;
    public AudioMixerSnapshot gameMusic;
    public AudioMixerSnapshot altMusic;
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
        if (altSong == false)
        {
            menuMusic.TransitionTo(0);
        }
        else
        {
            altMusic.TransitionTo(0);
        }

        setLevel();
        gameFinishCondition();
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

    public void setName(string n)
    {
        playerNameInput = n;
    }
    public string getName()
    {
        return playerNameInput;
    }

    public void setLevel(int l)
    {
        level = l;
    }
    public int getLevel()
    {
        return level;
    }
    public void switchAltMusic()
    {
        altSong = !altSong;
    }

    public void increaseScore()
    {
        score += 10;
    }

    public void setLevel()
    {
        if (SceneManager.GetActiveScene().name == "02 - GameL1")
        {
            level = 1;
        }
        if (SceneManager.GetActiveScene().name == "02 - GameL2")
        {
            level = 2;
        }
        if (SceneManager.GetActiveScene().name == "02 - GameL3")
        {
            level = 1;
        }
    }

    public void gameFinishCondition()
    {
        if(score == 50)
        {
            SceneManager.LoadScene("08 - MachineInstructions");
        }
    }

}
