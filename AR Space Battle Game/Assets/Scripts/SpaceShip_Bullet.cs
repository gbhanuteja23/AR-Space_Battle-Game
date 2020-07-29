using UnityEngine;
using System.Collections;

public class SpaceShip_Bullet : MonoBehaviour
{



    // Use this for initialization
    void Start()
    {

        StartCoroutine("Move");

        //StartCoroutine("Shoot");
    }

    // Update is called once per frame
    void Update()
    {

        transform.Translate(Vector3.forward * 1f * Time.deltaTime);

    }

    /*
    void ShootshipBullets()
    {
        GameObject bullet = Instantiate(Resources.Load("bullet", typeof(GameObject))) as GameObject;
        Rigidbody rb = bullet.GetComponent<Rigidbody>();

             

        //Vector3 position_val = transform.position;
        //Quaternion rotation_val = transform.rotation;

        float x = transform.position.x;
        float y = transform.position.y;
        float z = transform.position.z;

        Instantiate(Resources.Load("bullet", typeof(GameObject)), new Vector3(x,y,z), Quaternion.identity);
        

        //Vector3 position = GameObject.Find("SF_Free-Fighter Variant").transform.position;


        
        rb.AddForce(transform.forward * 500f);
        Destroy(bullet, 3);

        GetComponent<AudioSource>().Play();

    }
    
*/

    IEnumerator Move()
    {


        while (true)
        {
            yield return new WaitForSeconds(3.5f);
            transform.eulerAngles += new Vector3(0, 180f, 0);
            
        }
    }

    /*

    IEnumerator Shoot()
    {


        while (true)
        {
            yield return new WaitForSeconds(3.5f);
            
            ShootshipBullets();
        }
    }

    */

}