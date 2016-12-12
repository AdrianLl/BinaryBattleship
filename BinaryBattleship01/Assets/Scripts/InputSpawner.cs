using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;
using System.Linq;
public class InputSpawner : MonoBehaviour
{

    public int maxInputs;
    public GameObject explodingShips;
    public GameObject input;

    public float[] horizontalLocation;
    public float[] verticalLocation;

    public String[] xCoordinates;
    public String[] yCoordinates;

    private GameStates gameStates;

    private InputField x;
    private InputField y;
    private String xy;

    private AudioSource explosionAudio;

    void Start()
    {
        maxInputs = 5;

        horizontalLocation = new float[5] { -3.13f, -2.17f, 2.92f, 4.87f, 3.91f };
        verticalLocation = new float[5] { -1.72f, 3.25f, -0.72f, 1.26f, -2.73f };

        //xVals = 2,3,8,9,10
        //yVals = 7,2,6,8,4
        xCoordinates = new String[5] { "0010", "0011", "1000", "1010", "1001" };
        yCoordinates = new String[5] { "0111", "0010", "0110", "0100", "1000" };

        explosionAudio = GetComponent<AudioSource>();

    }

    public void inputCheck()
    {
        x = GameObject.Find("X Input").GetComponent<InputField>();
        y = GameObject.Find("Y Input").GetComponent<InputField>();

        String xNum = Convert.ToString(x.text);
        String yNum = Convert.ToString(y.text);


        for (int i = 0; i < maxInputs; i++)
        {
            if (xNum.Equals(xCoordinates[i]) && yNum.Equals(yCoordinates[i]))
            {
                int shipNum = i + 1;
                GameObject ship = GameObject.FindGameObjectWithTag("ship" + shipNum);
                explosionAudio.Play();
                GameData.Instance.increaseScore();
                Destroy(ship);
                Vector2 position = new Vector2(horizontalLocation[i], verticalLocation[i]);
                Instantiate(explodingShips, position, Quaternion.identity);


            }
        }
    }

    void Spawn(int shipNum)
    {
        Vector2 position = new Vector2(horizontalLocation[shipNum], verticalLocation[shipNum]);
        Instantiate(input, position, Quaternion.identity);
    }


}