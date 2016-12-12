using UnityEngine;
using System.Collections;

public class ShipSpawner : MonoBehaviour {

    public int maxShips;
    public GameObject ship;
    public float[] horizontalLocation;
    public float[] verticalLocation;
    private GameStates gameStates;


    void Start()
    {
        maxShips = 5;

        horizontalLocation = new float[5] { -3.13f, -2.17f, 2.92f, 4.87f, 3.91f };
        verticalLocation = new float[5] { -1.72f, 3.25f, -0.72f, 1.26f, -2.73f };
        // add different arrangements for different levels


    }

    public void spawnShips()
    {
        gameStates = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameStates>();

        if (gameStates.gameON)
        {
            Spawn();
        }
    }

    void Spawn()
    {
        int shipCount = 0;
        for (int i = 0; i < maxShips; i++)
        {
            shipCount++;
            Vector2 position = new Vector2(horizontalLocation[i], verticalLocation[i]);
            ship.tag = "ship" + shipCount;
            Instantiate(ship, position, Quaternion.identity);
        }

    }

}
