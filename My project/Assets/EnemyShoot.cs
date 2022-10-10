using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
    public float bullettime = 1;
    public float bulletspeed = 5;
    public GameObject player;
    public float close = 10.0F;
    public GameObject prefab;
    public float shootDelay = 1;
    float timer = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        Vector3 shootDir = player.transform.position - transform.position;
        float shootDist = shootDir.magnitude;
        shootDir.Normalize();
        if (shootDist <= close)
        {
            if (timer >= shootDelay)
            {
                //shoot
                timer = 0;
                GameObject bulletspawn = Instantiate(prefab, transform.position, Quaternion.identity);
                bulletspawn.GetComponent<Rigidbody2D>().velocity = shootDir * bulletspeed;
                Destroy(bulletspawn, bullettime);
            }

        }

    }
}
