using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;
using System.Linq;
public class InputSpawner : MonoBehaviour
{

    public int maxInputs;
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
        maxInputs = 4;

        horizontalLocation = new float[4] { -3.13f, -2.17f, 2.92f, 4.87f };
        verticalLocation = new float[4] { -1.72f, 3.25f, -0.72f, 1.26f };

        //xVals = 7,2,6,4
        //yVals = 2,3,8,10
        xCoordinates = new String[4] { "0111", "0010", "0110", "0100" };
        yCoordinates = new String[4] { "0010", "0011", "1000", "1010" };

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
                Debug.Log("ShipNumber" + shipNum);
                GameObject ship = GameObject.FindGameObjectWithTag("ship" + shipNum);
                explosionAudio.Play();
                Destroy(ship);

            }
        }
    }

    void Spawn(int shipNum)
    {
        Vector2 position = new Vector2(horizontalLocation[shipNum], verticalLocation[shipNum]);
        Instantiate(input, position, Quaternion.identity);
    }


}