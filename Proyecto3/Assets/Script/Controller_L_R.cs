using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller_L_R : MonoBehaviour
{ 
    //Variable que establece la velocidad de movimiento del Perdonaje
    float speed=15.0f; 

    float horizontalInput;

    //Variable que establece el limite de rango de la variable X
    private float limitX = 15.0f;

//Variable que se le asigna un objeto a lanzar
    public GameObject projectilePrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Le asigna el axis(horizontal) a la variable horizontalInput para usar los botones horizontales 
        horizontalInput = Input.GetAxis("Horizontal");

        //Permite el movimiento del que tenga el Script usando los botones de la variable horizontalInput
        this.transform.Translate(speed*Time.deltaTime*Vector3.right*horizontalInput);
        

        //Si la posicion X de este del que tenga este Script es menor a -limitX
        if (transform.position.x < -limitX)
        {
            //Manten su posicion en el Vector3(-limitX,y,z)
            //-15 es donde hasta donde puede llegar el valor de x
            //"y" y "z" seguiran teniendo los valores que tiene el Personaje
            transform.position = new Vector3(-limitX, transform.position.y, transform.position.z);
        }
        
        
        //Si la posicion X de este del que tenga este Script es mayor a limitX
        if (transform.position.x > limitX)
        {
            //Manten su posicion en el Vector3(limitX,y,z)
            //limitX es donde hasta donde puede llegar el valor de x
            //"y" y "z" seguiran teniendo los valores que tiene el Personaje
            transform.position = new Vector3(limitX, transform.position.y, transform.position.z);
        }


        //Accion de disparar
        if(Input.GetKeyDown(KeyCode.Space)){
            //Si el espacio se preciona dispara
            //Crea/inicializa un proyectil Instatiate
            //              (objeto      , en que posicion,    su rotacion)
            Instantiate(projectilePrefab,transform.position,projectilePrefab.transform.rotation);

        }
        
    }
}
