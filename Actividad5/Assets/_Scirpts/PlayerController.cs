using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Con esta linea dices que el script nomas funciona con objetos que tengan el componente RigidBody,
//si no lo tienen se lo agrega automaticamente
[RequireComponent(typeof(Rigidbody))]
public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRB;

    public float jumpForce;

    public float gravityMultpiplier;

    public bool isOnGround=false;
    // Start is called before the first frame update
    void Start()
    {
        //Le asigna el componente del RigidBody del objeto a la variable playerRB de tipo RigidBody
        playerRB = GetComponent<Rigidbody>();
        Physics.gravity *= gravityMultpiplier;

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space) && isOnGround)
        {
            //Le aplica la fuerza instantania de 1000Newton tomando en cuenta la masa
            playerRB.AddForce(Vector3.up*jumpForce,ForceMode.Impulse);
            isOnGround = false;
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            isOnGround = true;    
        }
        
    }
}
