using UnityEngine;
using System.Collections;

public class CollisionScript : MonoBehaviour
{
    //The below variables are for timer support
    const float totalRespawnSeconds = 1f;           //Time after which enemy ships will spawn

    float elapsedRespawnSeconds = 0;     //Time elapsed

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

            CreateEnemies();
            
        }
        
    }

    //for this to work both need colliders, one must have rigid body (spaceship) the other must have is that "istrigger" should be checked.
    void OnTriggerEnter(Collider col)
    {
        GameObject explosion = Instantiate(Resources.Load("BigExplosion Variant", typeof(GameObject))) as GameObject;
        explosion.transform.position = transform.position;
        Destroy(col.gameObject);
        Destroy(explosion, 3);       
       

        Destroy(gameObject);
    }


    
    

}