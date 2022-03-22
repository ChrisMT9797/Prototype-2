using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOB : MonoBehaviour
{
    private float topBound = 25;

    private float lowerBound = -3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Limits the range objects can exist
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < lowerBound)
        {
            //If applicable object goes beyond the established range, print "game Over!" and object is destroyed
            Debug.Log("Game Over!");
            Destroy(gameObject);
        }
    }
}
