using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ConversionKey : MonoBehaviour
{
    public Text tableText;

    void Start()
    {
        tableText = GetComponent<Text>();

    }

    void Update()
    {
        tableText.text =
            "0000 = 0\n" +
            "0001 = 1\n" +
            "0010 = 2\n" +
            "0011 = 3\n" +
            "0100 = 4\n" +
            "0101 = 5\n" +
            "0110 = 6\n" +
            "0111 = 7\n" +
            "1000 = 8\n" +
            "1001 = 9\n" +
            " 1010 = 10";
    }
}