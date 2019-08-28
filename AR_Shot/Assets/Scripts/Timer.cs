﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Timer : MonoBehaviour {

    float tt = 30f;
    Text txt;
    // Use this for initialization
    void Start () {
        txt = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
        if (tt > 0)
            tt -= Time.deltaTime;
        else
            SceneManager.LoadScene("End");

        txt.text = tt.ToString("N2");
	}
}
