using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;  //重新啟動遊戲指令系統

public class Player_Collision : MonoBehaviour {

    public Score_controls Score;

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
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            //Time.timeScale = 0;
        }
    }

    void OnTriggerEnter(Collider crosswall)
    {
        if (crosswall.gameObject.tag == "wall_trigger")
        {
            Score.score += 1;
        }
    }
}
