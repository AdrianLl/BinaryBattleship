using UnityEngine;
using System.Collections;

public class GameStates : MonoBehaviour {

    public bool gameON;

    public bool pauseON;

    public void toggleGameOn()
    {
        gameON = !gameON;
    }

    public void togglePauseON()
    {
        pauseON = !pauseON;
    }
}
