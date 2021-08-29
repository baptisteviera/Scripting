using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    public float speedFoward = 10.0f;
    public float speedTunr = 10.0f;
    private Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float fowardInput = Input.GetAxis("Vertical"); // commande z et s pour avancer
        transform.Translate(Vector3.forward*speedFoward*Time.deltaTime*fowardInput);
        float rotateInput = Input.GetAxis("Horizontal"); // comande q et d pour tourner
        transform.Rotate(Vector3.up*speedTunr*Time.deltaTime*rotateInput);
    }

    private void OnMouseDown()
    {
        rb.AddForce(transform.forward*250f);
    }
}
