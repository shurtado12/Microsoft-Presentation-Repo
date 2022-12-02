using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TurnText : MonoBehaviour
{
    // Start is called before the first frame update
    
    private string white = "White";
    private string black = "Black";
    private string turnText;
    private TMP_Text turnButton;
    void Start()
    {
        turnButton = transform.GetComponent<TextMeshProUGUI>();
        turnText = white;
        print($"Turn Test button value {turnButton.text}");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Turn.whiteTurn )
        {
            turnText = white;

        }

        if (!Turn.whiteTurn)
        {
            turnText = black;
        }

        print($"button {turnText}");
        turnButton.text = turnText;



        //myBtn.GetComponentInChildren<Text>().text = "my button text";
    }
}
