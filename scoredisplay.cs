﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class scoredisplay : MonoBehaviour {

    public Text scorefinal1;
    public Text scorefinal2;
    public float score01;
    public float score02;
    // Use this for initialization
    void Start () {
        score01 = PlayerPrefs.GetFloat("score");
        score02 = PlayerPrefs.GetFloat("scorecoin");
    }
	
	// Update is called once per frame
	void Update () {
        score01 = PlayerPrefs.GetFloat("score");
        score02 = PlayerPrefs.GetFloat("scorecoin");
        scorefinal1.text = "" + Mathf.Round(score01);
        scorefinal2.text = "" + Mathf.Round(score02);


    }
}
