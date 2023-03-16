using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutBounds : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    //Si el personaje que tenga este script llega a los limites en Z se destruye
        if (transform.position.z>32)
        {
            Destroy(this.gameObject);
        }

        if (transform.position.z < 0)
        {
            Debug.Log("GAME OVER");
            Destroy(this.gameObject);
            Time.timeScale = 0;
        }

    }
}
