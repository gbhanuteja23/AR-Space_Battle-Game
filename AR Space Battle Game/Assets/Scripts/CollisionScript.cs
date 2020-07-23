using UnityEngine;
using System.Collections;

public class CollisionScript : MonoBehaviour
{
    

    // Use this for initialization
    void Start()
    {
        //CreateEnemies();
    }

    // Update is called once per frame
    void Update()                            
    {        
        
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