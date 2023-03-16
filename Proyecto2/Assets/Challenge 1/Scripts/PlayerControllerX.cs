using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    [Range (0,100)]
     public float speed=0;
     [Range(0,50)]
     public float rotationSpeed=0;

     private float VerticalInput;

     private float RotationInput;

     private float RotacionLateral;
     // Start is called before the first frame update
   

    // Update is called once per frame
    void Update()
    {
        VerticalInput = Input.GetAxis("Vertical");
        RotationInput = Input.GetAxis("Camera");
        RotacionLateral = Input.GetAxis("Rotacion");
        
        //Se encarga de hacer avamzar o retroceder el objeto
        transform.Translate(speed*Time.deltaTime*Vector3.forward*VerticalInput);
        //Se encarga de hacer Rotar en el eje de las X al objeto
        transform.Rotate(rotationSpeed*Time.deltaTime*Vector3.right*RotationInput);
        
        //Rotacion lateral del objeto
        transform.Rotate(rotationSpeed*Time.deltaTime*Vector3.forward*RotacionLateral);
        
        
    }


}
