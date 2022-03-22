using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //the below function detext when an two object colliders interact
    void OnTriggerEnter(Collider other)
    {
        //when two object colliders interact, line one destroys this object, line two destroys other objects within the collision
        Destroy(gameObject);
        Destroy(other.gameObject);
    }
}
