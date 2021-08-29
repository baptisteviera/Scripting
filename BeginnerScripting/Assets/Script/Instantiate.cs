using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiate : MonoBehaviour
{
    public Rigidbody rocketPrefab;
    public Transform barrelEnd; // il s'agit du depart du lancement des boules

    void Start()
    {
        
    }

    void Update ()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            // on veut un rigidbody car on applique une force dessus !^^^^^^ù
            Rigidbody rocketInstance;
            rocketInstance = Instantiate(rocketPrefab, barrelEnd.position, barrelEnd.rotation) as Rigidbody;
            rocketInstance.AddForce(barrelEnd.up * 500); // barrelEnd.foward fonctionne bien aussi ça fait une parabol
        }
    }
}
