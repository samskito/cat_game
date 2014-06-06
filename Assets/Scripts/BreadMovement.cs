using UnityEngine;
using System.Collections;

public class BreadMovement : MonoBehaviour {
	public Vector2 speed = new Vector2(1, 1);
	public Vector2 direction = new Vector2(-1, 0);
	public Vector2 movement;

	// Use this for initialization
	void Start () {
		movement = new Vector2(
		speed.x * direction.x,
		speed.y * direction.y);
	}
	
	// Update is called once per frame
	void Update () {
		rigidbody2D.velocity = movement;
	}
}
