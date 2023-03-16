using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody))]

public class MoveLeftCilinders : MonoBehaviour
{
    public float speed = 2.0f;
    private Rigidbody obstacle;
    
    // Start is called before the first frame update
    void Start()
    {
        obstacle = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
         obstacle.AddForce(Vector3.left*speed,ForceMode.Acceleration);
        //this.transform.Translate(Vector3.left*speed*Time.deltaTime);
    }
}
