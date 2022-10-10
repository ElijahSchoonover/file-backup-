using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public float speed = 3;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float xinput = Input.GetAxis("Horizontal");
        Debug.Log(xinput);
        float yinput = Input.GetAxis("Vertical");
        GetComponent<Animator>().SetFloat("xinput" , xinput);
        GetComponent<Animator>().SetFloat("yinput" , yinput);

        Vector2 moveDirection = new Vector2(xinput, yinput);
        GetComponent<Rigidbody2D>().velocity = moveDirection * speed;
    }
}
