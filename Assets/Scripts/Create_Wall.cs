using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Create_Wall : MonoBehaviour {

    public GameObject Obj_Creat; //要生成的物件
    public float f_Time = 1.0f; //生成間隔

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {

        if (f_Time > 0)
        {
            f_Time -= Time.deltaTime;
        }

        else
        {
            GameObject Obj_Clone = Instantiate(Obj_Creat) as GameObject;
            f_Time = 1.0f;
        }

    }
}
