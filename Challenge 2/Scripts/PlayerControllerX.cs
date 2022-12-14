using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float fireRate = 1;
    private float nextFire = 0;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, if enough time has elapsed since last fire, send dog
        if (Input.GetKeyDown(KeyCode.Space) && Time.time > nextFire)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            //Reset nextFire to current time + fireRate
            nextFire = Time.time + fireRate;
        }
    }
}
