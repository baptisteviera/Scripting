using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCollider : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject otherSphere;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision otherSphere)
    {
        otherSphere.rigidbody.AddForce(transform.forward*100.0f);
    }
}
