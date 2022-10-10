using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Palyershot : MonoBehaviour
{
    public float bullettime = 1;
    public float bulletspeed = 5;
    public GameObject bullet;
    public AudioClip shootsound;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.timeScale == 1)

      if(Input.GetButtonDown("Fire1"))
        {
            GameObject bulletspawn = Instantiate(bullet, transform.position, Quaternion.identity);
           //bulletspawn.GetComponent<Rigidbody2D>().velocity = new Vector2(10, 0);

            Vector3 mouseposition = Input.mousePosition;
            mouseposition = Camera.main.ScreenToWorldPoint(mouseposition);
            Vector3 shotDir = mouseposition - transform.position;
            shotDir.Normalize();
            bulletspawn.GetComponent<Rigidbody2D>().velocity = shotDir; 
            bulletspawn.GetComponent<Rigidbody2D>().velocity = shotDir * bulletspeed;
            Destroy(bulletspawn,bullettime);
            Camera.main.GetComponent<AudioSource>().PlayOneShot(shootsound);
        }
     }
}
