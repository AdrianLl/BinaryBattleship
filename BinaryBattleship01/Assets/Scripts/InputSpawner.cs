using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class InputSpawner : MonoBehaviour {

    public int maxInputs;
    public GameObject input;

    public float[] horizontalLocation;
    public float[] verticalLocation;

    public int[] xCoordinates;
    public int[] yCoordinates;

    private GameStates gameStates;

    private InputField x;
    private InputField y;
    private String xy;

    void Start()
    {
        maxInputs = 4;

        horizontalLocation = new float[4] { -3.13f, -2.17f, 2.92f, 4.87f };
        verticalLocation = new float[4] { -1.72f, 3.25f, -0.72f, 1.26f };
        xCoordinates = new int[4] { 2, 7, 6, 4 };
        yCoordinates = new int[4] { 3, 2, 8, 10 };


    }

    public void inputCheck()
    {
        x = GameObject.Find("X Input").GetComponent<InputField>();
        y = GameObject.Find("Y Input").GetComponent<InputField>();

        int xNum = Convert.ToInt32(x.text);
        int yNum = Convert.ToInt32(y.text);


        for ( int i = 0; i< maxInputs; i++)
        {
            if(xNum == xCoordinates[i] && yNum == yCoordinates[i])
            {
                Debug.Log("entered hit");
                Spawn(i);
            }
        }
    }

    void Spawn(int shipNum)
    {
        Vector2 position = new Vector2(horizontalLocation[shipNum], verticalLocation[shipNum]);
        Instantiate(input, position, Quaternion.identity);
    }


}