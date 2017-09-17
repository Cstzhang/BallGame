using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {
	private Rigidbody2D rigidbodyBall;

	// start speed
	void Start () {
		rigidbodyBall = GetComponent<Rigidbody2D> ();
		int number = Random.Range (0, 2);
		if (number == 1) {
			rigidbodyBall.AddForce (new Vector2 (100, 0));
		} else {
			rigidbodyBall.AddForce (new Vector2 (-100, 0));
		
		}
	
	}
	//碰撞事件
	void OnCollisionEnter2D(Collision2D col) {
		print ("Oncollision");
		if (col.collider.tag == "Player") {
			print ("velocity");
			Vector2 velocity = rigidbodyBall.velocity;
			velocity.y = velocity.y/2 + col.rigidbody.velocity.y/2;
			rigidbodyBall.velocity = velocity;
		}
	
	}

}
