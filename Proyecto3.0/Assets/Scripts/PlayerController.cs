using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
//Variable para guardar la direccion de movimiento del movimiento horizontal
public float horizontalInput;
//Velocidad de movimiento
public float speed =10.0f;
//Limite de rango de movimiento del personaje
private int limitX = 20;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    //Le da el valor del boton para moverse horizontalmente
        horizontalInput = Input.GetAxis("Horizontal");
        //traslada al peronaje que tenga el script de forma horizontal
        transform.Translate(Vector3.right * Time.deltaTime * speed * horizontalInput);
        //Condicion si llega a los limites de  X el personaje se queda en ese lugar
        if (transform.position.x>limitX)
        {
            transform.position = new Vector3(limitX, transform.position.y, transform.position.z);
        }

        if (transform.position.x<-limitX)
        {
            transform.position = new Vector3(-limitX, transform.position.y, transform.position.z);

        }
    }
}
