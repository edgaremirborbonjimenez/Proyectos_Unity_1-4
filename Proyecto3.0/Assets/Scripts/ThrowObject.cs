using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowObject : MonoBehaviour
{
    //Arreglo de prpyectiles
    public GameObject[] proyectiles;
    //Indeice del proyectil a lanzar
    int projectileIndex ;

    
    // Start is called before the first frame update
    void Start()
    {
   

    }

    // Update is called once per frame
    void Update()
    {
        //Le da un indice aleatorio a spawnear
        projectileIndex = Random.Range(0, proyectiles.Length);
        
        //Si preciona Espacio
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Instancia un GameObject que es el proyectil
            Instantiate(proyectiles[projectileIndex],transform.position, proyectiles[projectileIndex].transform.rotation);
        }
    }
}
