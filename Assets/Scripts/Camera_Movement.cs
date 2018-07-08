using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Movement : MonoBehaviour {

    [SerializeField]
    public float MoveSpeed = 4;

    // Use this for initialization
    void Start () {
		
	}

    // Update is called once per frame
    void FixedUpdate(){

        //Move
        transform.Translate(Time.deltaTime * MoveSpeed, 0, 0);

    }
}
