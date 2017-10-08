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
    public int jumpCount = 1;
    float maxDistance = 1.0f;
    public bool cMove = false;
    float playerDistance;
    public GameObject piller;
    public bool keyVale = false;

    void Start () {
        r = GetComponent<Rigidbody>();
	}

    void Update()
    {
        Move();

        Ray ray = new Ray(player.transform.position, Vector3.down);
        RaycastHit hit;

        //着地判定
        if (Physics.Raycast(ray,out hit,maxDistance))
        {
            float dis = hit.distance;
            if (dis < 0.6f&&hit.collider.gameObject.tag == "Stage")
            {
                playerDistance = player.transform.position.z - hit.collider.gameObject.transform.position.z;
                //if (player.transform.position.z>piller.transform.position.z)
               // {
					hit.collider.transform.root.gameObject.transform.position = new Vector3(
						hit.collider.transform.root.gameObject.transform.position.x,
						hit.collider.transform.root.gameObject.transform.position.y,
						hit.collider.transform.root.gameObject.transform.position.z + playerDistance
					);
                //}

                jumpCount = 1;
                //hit.collider.transform.root.gameObject.transform.position;
            }
            else jumpCount = 0;
        }
    }

    void Move(){
		//マウスがタッチされたポジションを取得
        if (Input.GetMouseButtonDown(0))
		{
            cMove = true;
			startPos = Input.mousePosition;

		}

		//マウスが離されたポジションを取得
		//マウスの移動距離を計算してPlayerのX座標にぶち込む
        if (Input.GetMouseButton(0))
		{
			Vector2 direct = Input.mousePosition;
			this.speed = direct.x - startPos.x;
			player.transform.position += new Vector3(speed * 0.001f, 0, 0);
		}
    }

    public void Jump() {
        if (jumpCount == 1)
        {
            r.AddForce(Vector3.up * jumpSpeed);
        }
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag =="Key")
        {
            keyVale = true;
            Destroy(collision.gameObject);
        }
    }
}
