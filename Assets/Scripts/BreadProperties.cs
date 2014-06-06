using UnityEngine;
using System.Collections;

public class BreadProperties : MonoBehaviour {
	public int gain = 1;
	public bool isTaken = false;

	public Vector2 defaultPosition = new Vector2(3.524438f, 0.06457932f);
	public Transform breadPrefab;

	// Use this for initialization
	void Start () {
		Destroy(gameObject, 10); // after 10 sec
	}
	
	void OnTriggerEnter2D(Collider2D otherCollider) {
		Destroy(gameObject);
	}

	// When bread is destroyed
	void OnDisable() {
		var newBread = Instantiate(breadPrefab) as Transform;
		BreadMovement move = newBread.gameObject.GetComponent<BreadMovement>();

		newBread.position = defaultPosition;
		newBread.gameObject.AddComponent(Rigidbody);

		Debug.Log(move);	
		//move.direction = this.transform.right;
	}
}
