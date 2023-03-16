using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/*
Clase que se ocupa de dar la funcion de Spawn a los enemigos
*/
public class SpawnManager : MonoBehaviour
{

    public GameObject[] enemies;
    public int animalIndex;    
    //Localizacion X y Z del spawn
    private float spawnPX=15f,spawnPZ;
    

    // Start is called before the first frame update
    void Start()
    {
        spawnPZ = transform.position.z;
    }

    // Update is called once per frame
    void Update()
    {
        //Si el indice solicitado del arreglo es >=0 y es menor que length
        //if(animalIndex>=0 && animalIndex< enemies.Length){ 

            if(Input.GetKeyDown(KeyCode.S)){
                
                //Rangos de posicionamiento
                float xrange = Random.Range(-spawnPX, spawnPX);
                Vector3 spawnPos = new Vector3(xrange, 0, spawnPZ);
                
                //Indice aleatorio
                animalIndex = Random.Range(0, enemies.Length);

                //Spawnea un animal 
            //              objeto             posicion               rotacion
            Instantiate(enemies[animalIndex],spawnPos,enemies[animalIndex].transform.rotation);
            } // }else{

        //   Debug.LogError("El enemigo a instanciar NO existe");
       // }
       
    }
}
