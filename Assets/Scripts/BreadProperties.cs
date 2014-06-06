using UnityEngine;
using System.Collections;

public class BreadProperties : MonoBehaviour {
	public int gain = 1;
	public bool isTaken = false;

	public Vector2 defaultPosition = new Vector2(3.524438f, 0.06457932f);
	public GameObject breadPrefab;

	// Use this for initialization
	void Start () {
		Destroy(gameObject, 10); // after 10 sec
	}
	
	void OnTriggerEnter2D(Collider2D otherCollider) {
		Destroy(gameObject);
	}

	// When bread is destroyed
	void OnDisable() {
		//Rigidbody newBread = (Rigidbody) Instantiate(breadPrefab);
		GameObject newBread = (GameObject)Resources.Load("/Prefabs/piece_of_bread");
		//var BreadMovement = GetComponent<BreadMovement>();
		newBread.transform.position = defaultPosition;
		//newBread.velocity = BreadMovement.movement;
	}
}
