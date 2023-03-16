using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
[SerializeField]
    private GameObject player;

    //[SerializeField]
    private Vector3 offset = new Vector3(0, 5, -5);
    
    private void Start()
    {
        transform.Rotate(20,0,0);
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = player.transform.position+offset;
    }
}
