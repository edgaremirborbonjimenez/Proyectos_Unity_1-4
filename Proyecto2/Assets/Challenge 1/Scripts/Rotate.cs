using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    //private float Rotacion;
    private float speed;
    void Update()
    {
       // Rotacion = Input.GetAxis("Vertical");
        speed = 5000;
        transform.Rotate(speed*Time.deltaTime*Vector3.forward);
        
    }
}
