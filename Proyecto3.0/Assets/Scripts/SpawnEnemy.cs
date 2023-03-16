using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Este Script debe de estar asignado a un SpawnManager
public class SpawnEnemy : MonoBehaviour{

//Arreglo que contendra los enemigos
    public GameObject[] enemigos;
    //Indice del enemigo
    private int indexEnemy;
    
    //posicionX de Spawn
    private float posX;
    //posicionZ de Spawn
    private float posZ;
    //Lo mismo pero en Y
    private float posY;
    //rotacion que tendran los enemigos
    private  Quaternion rotation;
    //Variable donde guardaremos la posicion en donde se spawneara el enemigo 
    private Vector3 posicion;

    //Tiempo en el que tardara en empezar a spawnear enemigos
    public float start = 2.0f;
    //Tiempo que tardara en spawnear al enemigo cada que spawnea uno
    public float delay = 1.5f;
    
    // Start is called before the first frame update
    void Start()
    {
    //Como la posicion Z al spawnear sera la misma, le asignamos el valor z del SpawnManager
    //Para que no se tenga que asignar esto en cada actualizacion y ya este en el inicio
        posZ = transform.position.z;
    //Lo mismo con la rotacion
        rotation = transform.rotation;
        //Lo mismo pero en Y
        posY = transform.position.y;
            
        //Funcion que se encarga de llamar al metodo del primer valor del parametro segun
        //los dos valores de tiempo de inicio(start) y tiempo en repetir(delay)
        //Llama la funcion spawn para spawnear al enemigo cada intervalo de tiempo
        
        InvokeRepeating("spawn",start,delay);
            
    }

    // Update is called once per frame
    void Update()
    {

    }
    //Funcion que se encarga de spawnear al enemigo
    private void spawn(){
        
    //Le asigna un numero random al indexEnemy para seleccionar alguno del arreglo
        indexEnemy = Random.Range(0, enemigos.Length);
        
        //Le asigna una posicion X Random el posX para spawnear en una posicion aleatoria en x
        posX = Random.Range(-20, 20);
            
        //Le asignamos al spawn un Vector 3 con la posicion del enemigo usarn la variable posX, 
        //la posicion del spawn manager en Y y el posZ
        posicion = new Vector3(posX, posY, posZ);
        
        //Instancia un GameObject que es el enemigo en el arreglo de enemigos
        //Buscamos al enemigo con el indexEnemy,le damos la variable posicion y rotacion
        Instantiate(enemigos[indexEnemy], posicion, rotation);
    }
}
