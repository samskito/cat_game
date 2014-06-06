using UnityEngine;
using System.Collections;

public class CatLife : MonoBehaviour {

	public int hp = 9; // cats got 9 lives man

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
	}

	public void changeLifeLabel() {
		GetComponent<CatLifeLabel>().labelText = "Life = " + hp;
	}
}
