using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Collision : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {

    }

    void OnCollisionEnter(Collision hitwall) //hitwall為自定義碰撞事件
    {
        if (hitwall.gameObject.tag == "wall") //如果hitwall碰撞事件的物件標籤名稱是wall
        {
            Time.timeScale = 0;
        }
    }
}
