using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;


    private float counter = 2.0f;

    private float nextShoot = 2.0f;
    // Update is called once per frame
    void Update()
    {
        counter += Time.deltaTime;
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && counter>=nextShoot && Time.timeScale>0)
        {
            counter = 0.0f;
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
        }
    }
}
