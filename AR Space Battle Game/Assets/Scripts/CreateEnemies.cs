using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateEnemies : MonoBehaviour
{
    //The below variables are for timer support
    const float totalRespawnSeconds = 5f;           //Time after which enemy ships will spawn

    float elapsedRespawnSeconds = 0;     //Time elapsed

    //int enemies = 0;  //No of enemy ships to spawn

    // Use this for initialization
    void Start()
    {
        //CreateEnemies();
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
                    createEnemies();
                }
            }
            
        }

    }

    void createEnemies()
    {

        float x = Random.Range(-12, 20);   //For spawning the enemy ships at random places between the specified range
        float y = Random.Range(6, 8);
        float z = Random.Range(-3, -25);

        Instantiate(Resources.Load("enemy1", typeof(GameObject)), new Vector3(x, y, z), Quaternion.identity);

    }
}
