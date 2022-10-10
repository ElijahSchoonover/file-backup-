using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class health : MonoBehaviour
{
    public int Health = 10;
    public Text healthtext;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        healthtext.text = "Health" + Health;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        string othertag = collision.gameObject.tag;
        if (othertag == "damge")
        {
            Health--;
            if (Health <= 0)
            {
                Scene scene = SceneManager.GetActiveScene();
                SceneManager.LoadScene(scene.name);
            }
        }
    }
}