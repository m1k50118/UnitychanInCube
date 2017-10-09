using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

    public static float timer;
    public Text timeLabel;
    public float beforeTime = 0.0f;
	// Use this for initialization
	void Start () {
        timeLabel = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
        timer += Time.deltaTime;
        timeLabel.text = "Time:" + timer.ToString("f2") + "s";
	}
}
