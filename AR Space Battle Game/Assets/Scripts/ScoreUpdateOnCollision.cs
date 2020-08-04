using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreUpdateOnCollision : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision col)
    {
        if(col.transform.name=="Player")
        {
            Debug.Log("Collided");
            ShowScore.score_count += 1;
        }
    }
}
