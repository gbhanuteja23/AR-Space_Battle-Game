using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateEnemies : MonoBehaviour
{
    //The below variables are for timer support
    const float totalRespawnSeconds = 5f;           //Time after which enemy ships will spawn

    float elapsedRespawnSeconds = 0f;     //Time elapsed

    

    // Use this for initialization
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //update the timer and check whether it's done
        elapsedRespawnSeconds += Time.deltaTime;
        if (elapsedRespawnSeconds >= totalRespawnSeconds)
        {
            //Reset the timer 
            //And spawn enemy ships
            elapsedRespawnSeconds = 0;
                      
            if(GameObject.FindGameObjectsWithTag("Player").Length==0)
            {
                for(int i=0; i<5; i++)   //To spawn 5 enemies if all enemy ships gets destroyed
                {
                    CreateEnemiesFunc();
                }
            }
            
        }

    }

    void CreateEnemiesFunc()
    {

        float x = Random.Range(-28.5f, 32.6f);   //For spawning the enemy ships at random places between the specified range
        float y = Random.Range(8f, -8f);
        float z = Random.Range(-17.35f, -6f);

        Instantiate(Resources.Load("SF_Free-Fighter Variant", typeof(GameObject)), new Vector3(x, y, z), Quaternion.identity);

    }
}
