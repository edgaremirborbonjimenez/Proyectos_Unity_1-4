using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
//Velocidad
    public float speed = 10.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    //Mueve hacia adelante al personaje que tenga este script
        transform.Translate(Vector3.forward*Time.deltaTime*speed);
    }
}
