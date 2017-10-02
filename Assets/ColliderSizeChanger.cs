using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderSizeChanger: MonoBehaviour {

    BoxCollider b;
    public bool flag = false;

	// Use this for initialization
	void Start () {
        b = GetComponent<BoxCollider>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.A))
        {
            flag = !flag;
			if (flag)
			{
				b.size = new Vector3(100f, 1f, 1f);
			}
			else b.size = new Vector3(1f, 1f, 100f);
        }

    }
}
