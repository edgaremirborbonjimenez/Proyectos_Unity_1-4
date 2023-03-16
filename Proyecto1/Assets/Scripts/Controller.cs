using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    
    [Range(5,20),SerializeField]
    private float velocidad=10f;

    private float velocidadLateral = 20f;

    public float horizontalInput;
    private float verticalInput;

    private void Start()
    {
        Debug.Log("GO!!!");
    }

    // Update is called once per frame
    void Update()
    {

        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
                
        
        this.transform.Translate(velocidad*Time.deltaTime*Vector3.forward*verticalInput);

        if (verticalInput!=0)
        {
    

            transform.Rotate(velocidadLateral * Time.deltaTime * Vector3.up * horizontalInput);
        }

    }

   
}
