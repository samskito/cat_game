using UnityEngine;
using System.Collections;

public class CatLifeLabel : MonoBehaviour {

	public string labelText = "";

	private void OnGUI() {
		GUI.Label(new Rect(200, 15, 75, 75), labelText);
	}
}
