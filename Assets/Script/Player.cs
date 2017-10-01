using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    private Vector2 startPos;
    private Vector2 endPos;
    float speed = 0;
    public GameObject player;

	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            startPos = Input.mousePosition;
        }

        if (Input.GetMouseButton(0))
        {
            Vector2 direct = Input.mousePosition;
            this.speed = direct.x - startPos.x;
            player.transform.localPosition += new Vector3(speed * 0.001f, 0, 0);
            Debug.Log(player.transform.position.x);
        }
    }
}
