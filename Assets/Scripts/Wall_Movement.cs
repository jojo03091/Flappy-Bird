using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall_Movement : MonoBehaviour {

    [SerializeField]
    public float MoveSpeed = 4;
    public float X;
    public float Y;

    // Use this for initialization
    void Start () {
        transform.Translate(0, Random.Range(6f, 8.5f), 0);
    }
	
	// Update is called once per frame
	void FixedUpdate () {

        //Move
        transform.Translate(Time.deltaTime * -MoveSpeed, 0, 0);

        //Get walls' x & y
        X = GetComponent<Transform>().position.x;
        Y = GetComponent<Transform>().position.y;

        //Destroy the wall
        if (X < -11) {
            Destroy(gameObject);
        }
    }
}
