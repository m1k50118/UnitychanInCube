using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateTest : MonoBehaviour {

    public Transform player;
    public GameObject[] stages;
	public bool flag = false;

    private void Start()
    {
        stages = GameObject.FindGameObjectsWithTag("Stage");
    }

    private IEnumerator Tween(Vector3 axis, float angle, int flame){
        float deltaAngle = angle / (float)flame;
		
        foreach (var stage in stages)
		{
            if (flag)
            {
                stage.gameObject.GetComponent<BoxCollider>().size = new Vector3(100f, 1f, 1f);
            }
            else stage.gameObject.GetComponent<BoxCollider>().size = new Vector3(1f, 1f, 100f);
        }

		for (int i = 0; i < 30; i++)
        {
            transform.RotateAround(player.position, axis, deltaAngle);
			yield return null;
        }
    }

    public void RightRotate(){
        flag = !flag;
		StartCoroutine(Tween(Vector3.up, 90f, 30));
    }

    public void LeftRotate(){
        flag = !flag;
		StartCoroutine(Tween(Vector3.up, -90f, 30));
    }

}
