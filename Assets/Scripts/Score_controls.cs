using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;  //To read UI

public class Score_controls : MonoBehaviour {

    public int score = 0;
    public Text score_view;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        score_view.text = "Score : " + score;
	}
}
