using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    private Vector2 startPos;
    private Vector2 endPos;
    Rigidbody r;
    float speed = 0;
    public float jumpSpeed = 500f;
    public GameObject player;
    int jumpCount = 1;

	// Use this for initialization
	void Start () {
        r = GetComponent<Rigidbody>();
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
            player.transform.position += new Vector3(speed * 0.001f, 0, 0);
            // Debug.Log(player.transform.position.x);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag=="Stage")
        {
            jumpCount = 1;
        }

    }

    private void OnCollisionExit(Collision collision)
    {
        jumpCount = 0;
    }

    public void Jump(){
        
        if (jumpCount==1)
        {
            r.AddForce(Vector3.up * jumpSpeed);
        }
    }
}
