using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeguirJugador : MonoBehaviour
{
    public GameObject plane;
    private Vector3 offset = new Vector3(0.0788134f,3.023346f,-7.626066f);

    // Start is called before the first frame update
    void Start()
    {
        transform.Rotate(9.317f,0.104f,0);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = plane.transform.position + offset;
    }
}