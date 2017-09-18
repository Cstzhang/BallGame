using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {
	//外界只能访问
	private static GameManager _instance;
	public static GameManager Instance {
		get { 
			return _instance;
		}
	}

	private BoxCollider2D rightWall;
	private BoxCollider2D leftWall;
	private BoxCollider2D upWall;
	private BoxCollider2D downWall;
	public Text score1Text;
	public Text score2Text;


	public Transform player1;
	public Transform player2;

	private int score1;
	private int score2;

	void Awake() {
		_instance = this;
	}

	// Use this for initialization
	void Start () {
		ResetWall();
		ResetPlayer();
	}

	// reset wall
	void ResetWall() {
		rightWall = transform.Find ("rightWall").GetComponent<BoxCollider2D> ();
		leftWall  = transform.Find ("leftWall").GetComponent<BoxCollider2D> ();
		upWall    = transform.Find ("upWall").GetComponent<BoxCollider2D> ();
		downWall  = transform.Find ("downWall").GetComponent<BoxCollider2D> ();
		print ("hello it is me ");
//		Vector3 upWallPosition = Camera.main.ScreenToWorldPoint (new Vector2 (Screen.width / 2, Screen.height));
//		upWall.transform.position = upWallPosition; 
//		//upWall width
//		float width =  Camera.main.ScreenToWorldPoint(new Vector2(Screen.width,Screen.height)).x * 2;
//		upWall.size = new Vector2 (width, 1);
//		//Y +0.5
//		upWall.transform.position = upWallPosition +  new Vector3(0,0.5f,0);

		// 屏幕右上角未知
		Vector3 tmpPosition = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width,Screen.height));
		//upWall
		upWall.transform.position = new Vector3(0,tmpPosition.y+0.5f,0);
		upWall.size = new Vector2 (tmpPosition.x * 2, 1);
		//downWall
		downWall.transform.position = new Vector3(0,-tmpPosition.y-0.5f,0);
		downWall.size = new Vector2 (tmpPosition.x * 2, 1);
		//rightWall
		rightWall.transform.position = new Vector3(tmpPosition.x+0.5f,0,0);
		rightWall.size = new Vector2 (1, tmpPosition.y*2);
		//leftWall
		leftWall.transform.position = new Vector3(-tmpPosition.x-0.5f,0,0);
		leftWall.size =new Vector2 (1, tmpPosition.y*2);

	}

	// reset player position
	void ResetPlayer() {
		Vector3 player1Position = Camera.main.ScreenToWorldPoint(new Vector3(100,Screen.height/2,0));
		player1Position.z = 0;
		player1.position = player1Position;

		Vector3 player2Position = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width-100,Screen.height/2,0));
		player2Position.z = 0;
		player2.position = player2Position;

	}
	// 计分
	public void ChangeScore(string wallName) {
		if (wallName == "leftWall") {
			score2++;
		
		} else if (wallName == "rightWall") {
			score1++;
		
		}
		score1Text.text = score1.ToString();
		score2Text.text = score2.ToString();

	}

	//重置
	public void Reset() {
		score1 = 0;
		score2 = 0;
		score1Text.text = score1.ToString();
		score2Text.text = score2.ToString();
		GameObject.Find ("Ball").SendMessage ("Reset");

	}




}
