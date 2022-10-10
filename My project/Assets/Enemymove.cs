using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemymove : MonoBehaviour
{
    public GameObject player;
    public float close = 10.0F;
    public float speed = 5.0F;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 playerDir = player.transform.position - transform.position;
        float playerDist = playerDir.magnitude;
        playerDir.Normalize();
        if (playerDist <= close)
        {
            //if player is close,chase palyer
          GetComponent<Rigidbody2D>().velocity = playerDir * speed;
        }
        else
        {
            GetComponent<Rigidbody2D>().velocity = Vector3.zero;
        }
        GetComponent<Animator>().SetFloat("xinput", playerDir.x);
        GetComponent<Animator>().SetFloat("yinput", playerDir.y);
    }
}
