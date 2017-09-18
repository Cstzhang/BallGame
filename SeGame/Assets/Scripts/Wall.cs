using UnityEngine;
using System.Collections;

public class Wall : MonoBehaviour {
	private AudioSource gameAudio;
	// Use this for initialization
	void Start () {
		gameAudio = GetComponent<AudioSource> ();
	}
	
	//碰撞播放声音
	void OnCollisionEnter2D() {
		gameAudio.Play ();
	}
}
