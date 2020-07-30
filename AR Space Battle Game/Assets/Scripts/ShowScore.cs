using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowScore : MonoBehaviour
{
    public int score_count = 0;  //To count the no of enemy spaceships destroyed

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider col)
    {
        score_count = score_count + 1;    //Whenever you destroy a enemy spaceship, increase score by 1
    }
}
