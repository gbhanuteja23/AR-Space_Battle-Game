using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowScore : MonoBehaviour
{
    public static int score_count = 0;  //To count the no of enemy spaceships destroyed

    public Text scoreDisplay;  //Variable to display score on canvas

    // Start is called before the first frame update
    void Start()
    {
        scoreDisplay = GetComponent<Text>();

        
    }

    // Update is called once per frame
    void Update()
    {
        scoreDisplay.text = "Enemies Destroyed:   " + score_count.ToString();
    }

}
