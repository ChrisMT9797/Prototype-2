using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    public float speed = 45.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //this moves applicable objects forward at a constant rate
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
