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

		if (col.gameObject.name == "rightWall" || col.gameObject.name == "leftWall") {
			GameManager.Instance.ChangeScore (col.gameObject.name);		
		}







	
	}

	void Update() {
		Vector2 velocity = rigidbodyBall.velocity;
		if (velocity.x < 9 || velocity.x > -9 && velocity.x != 0) {
			if (velocity.x > 0) {
				velocity.x = 10;
			}
			if (velocity.x < 0) {
				velocity.x = -10;
			}
			rigidbodyBall.velocity = velocity;
		
		
		}
	
	
	}


}
