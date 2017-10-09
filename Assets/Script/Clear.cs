using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Clear : MonoBehaviour {

    public Text clearTime;

	// Use this for initialization
	void Start () {
        clearTime = GetComponent<Text>();
        Debug.Log(Timer.timer);
	}
	
	// Update is called once per frame
	void Update () {
        clearTime.text = "Time:" + Timer.timer.ToString("f2") + "s";
	}
}
