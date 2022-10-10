using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class condtion : MonoBehaviour
{
        int level = 3;
       public int XP = 10;
       public int levelUpXP = 15;    
    // Start is called before the first frame update
    void Start()
    {

        
    }

    // Update is called once per frame
    void Update()
    {
        if (XP >= levelUpXP)
        {
            level++;
            XP = XP - levelUpXP;
            levelUpXP += 10;
            Debug.Log("Ding congratulations, you've reached level " + level); 


        }
    }
}
