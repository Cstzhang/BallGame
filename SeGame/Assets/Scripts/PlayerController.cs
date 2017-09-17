using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
	public KeyCode upKey;
	public KeyCode downKey;
	public float speed = 10;
	private Rigidbody2D firstRigidbody2d;

	// Use this for initialization
	void Start () {
		firstRigidbody2d = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {//两个键同时按的话，上的优先级高
		if (Input.GetKey (upKey)) {
			//向上移动 控制Y移动 
			firstRigidbody2d.velocity = new Vector2 (0, speed);
		} else if(Input.GetKey(downKey)) {
			//按下
			firstRigidbody2d.velocity = new Vector2 (0, -speed);
		
		}else {
			//按钮抬起
			firstRigidbody2d.velocity = new Vector2 (0, 0);

		}
	
	}
}
