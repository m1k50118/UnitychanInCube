using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlidPos : MonoBehaviour {

    public GameObject Player;
    float distance;
    public bool cSlid = true;
    Player b;

	// Use this for initialization
	void Start () {
        Debug.Log(gameObject.transform.position);
        b = GetComponent<Player>();
	}
	
	// Update is called once per frame
	void Update () {
        cSlid = !b.cMove;
	}

    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.tag == "Player"&&cSlid)
        {
            //Debug.Log(gameObject.transform.position.z);
            distance = collision.gameObject.transform.position.z - gameObject.transform.position.z;
            gameObject.transform.position = new Vector3(collision.gameObject.transform.position.x, gameObject.transform.position.y, collision.transform.position.z);
        }
    }
}
