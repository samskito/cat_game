using UnityEngine;
using System.Collections;

public class CatLife : MonoBehaviour {

	public int hp = 9; // cats got 9 lives man
	
	public Vector2 defaultPosition = new Vector2(3.524438f, 0.06457932f);
	public Transform breadPrefab;

	void Start() {
		changeLifeLabel();
	}

	public void Damage(int damageCount) {

	}

	void OnTriggerEnter2D(Collider2D otherCollider) {
		BreadProperties bread = otherCollider.gameObject.GetComponent<BreadProperties>();

		if (bread != null) {
			hp += bread.gain;
			changeLifeLabel();
		}

		spawnNewBread();
	}

	public void changeLifeLabel() {
		GetComponent<CatLifeLabel>().labelText = "Life = " + hp;
	}

	private void spawnNewBread() {
		var newBread = Instantiate(breadPrefab) as Transform;
		newBread.position = defaultPosition;
	}
}
