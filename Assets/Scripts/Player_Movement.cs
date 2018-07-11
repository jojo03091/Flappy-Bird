using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour {

    [SerializeField]
    public int JumpHigh = 500;

    [SerializeField]
    public float gra = 5;

    private Rigidbody rb;

    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate () {

        //Press SPACE to jump
        if (Input.GetMouseButtonDown(0))
        {
            rb.AddForce(Vector3.up * JumpHigh);
        }
        else
        {
            rb.AddForce(Vector3.down * gra);
        }
    }
}
