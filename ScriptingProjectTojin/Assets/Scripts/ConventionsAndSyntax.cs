using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConventionsAndSyntax : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(transform.position.x);

        if (transform.position.y <=5f)
    

    // Update is called once per frame
    
        {
            Debug.Log("I'm about to hit the ground!");
        }
    }
}
