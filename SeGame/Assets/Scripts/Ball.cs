using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {
	private Rigidbody2D rigidbody2D;

	// Use this for initialization
	void Start () {
		rigidbody2D = GetComponent<Rigidbody2D> ();
		int number = Random.Range (0, 2);
	
		if (number == 1) {
			rigidbody2D.AddForce (new Vector2 (100, 0));


		} else {
			rigidbody2D.AddForce (new Vector2 (-100, 0));
		
		}
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
