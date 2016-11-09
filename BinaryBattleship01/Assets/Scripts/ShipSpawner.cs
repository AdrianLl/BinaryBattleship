using UnityEngine;
using System.Collections;

public class ShipSpawner : MonoBehaviour {

    public int maxShips;
    public GameObject ship;
    public int horizontalMin;
    public int horizontalMax;
    public int verticalMin;
    public int verticalMax;

    //public Vector2 originalPosition;

    // Use this for initialization
    void Start()
    {
        maxShips = 5;
        horizontalMin = -10;
        horizontalMax = 10;
        verticalMin = 0;
        verticalMax = 4;

        //originalPosition = transform.position;
        Spawn();

    }

    void Spawn()
    {
        for (int i = 0; i < maxShips; i++)
        {

            Vector2 randomPosition = new Vector2(Random.Range(horizontalMin, horizontalMax), Random.Range(verticalMin, verticalMax));
            Instantiate(ship, randomPosition, Quaternion.identity);

        }

    }
}