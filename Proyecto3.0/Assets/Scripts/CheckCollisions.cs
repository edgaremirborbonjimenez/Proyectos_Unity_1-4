using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckCollisions : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Detecta si otro objeto se adentro a la zona del trigger del objeto con el script
    //Este metodo se llamara cuando un objeto entre en el trigger del objeto del script
    private void OnTriggerEnter(Collider other)
    {
        //Si detecta colision con el trigger destruye este objeto y el que se adentro
        
        //le agregue un if con la condicion si el objeto que esta entrando al trigger tiene esa etiqueta es true ,en caso contrario es false
        if (other.CompareTag("projectile"))
        {
            Destroy(this.gameObject); //Destruye este objeto
            Destroy(other.gameObject); //Destruye al objeto que entra al trigger
        }
    }
}
