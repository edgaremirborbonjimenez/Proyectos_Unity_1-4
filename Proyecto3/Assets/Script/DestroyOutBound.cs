using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutBound : MonoBehaviour
{

    private float limitTop = 31f;
    private float limitBot = -12f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Si el objeto con este script supera limitTop en el eje z 
        // o es menor al limite limitBot
        if(this.transform.position.z>limitTop||this.transform.position.z<limitBot){
            //Destruyelo
            Destroy(this.gameObject);
        }
    }
}
