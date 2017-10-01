using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateTest : MonoBehaviour {

    public Transform player;

    private void Start()
    {
        
    }

    private IEnumerator Tween(Vector3 axis, float angle, int flame){
        float deltaAngle = angle / (float)flame;
        for (int i = 0; i < 30; i++)
        {
            transform.RotateAround(player.position, axis, deltaAngle);
			yield return null;
        }

    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.A))
        {
            StartCoroutine(Tween(Vector3.up, 90f, 30));
        }
    }

}
