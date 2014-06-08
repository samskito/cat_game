using UnityEngine;
using System.Collections;

public class BreadProperties : MonoBehaviour {
	public int gain = 1;
	public bool isTaken = false;

	// Use this for initialization
	void Start () {
		Destroy(gameObject, 10); // after 10 sec
	}
	
	void OnTriggerEnter2D(Collider2D otherCollider) {
		Destroy(gameObject);
	}

	// When bread is destroyed
	void OnDisable() {

		//newBread.gameObject.AddComponent(Rigidbody);
		//Debug.Log(move);	
		//move.direction = this.transform.right;
	}
}
