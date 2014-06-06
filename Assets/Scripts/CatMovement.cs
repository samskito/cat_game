using UnityEngine;
using System.Collections;

public class CatMovement : MonoBehaviour {
	//Vector3 velocity = Vector3.zero;
	public Vector2 speed = new Vector2(5, 5);
	public Vector2 movement;
	//public Vector3 gravity;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		//velocity = gravity;
		//transform.position += velocity * Time.deltaTime;

		float inputX = Input.GetAxis("Horizontal");
		float inputY = Input.GetAxis("Vertical");

		movement = new Vector2 (speed.x * inputX, speed.y * inputY);

	}

	void FixedUpdate() {
		rigidbody2D.velocity = movement;
	}
}
