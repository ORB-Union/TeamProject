using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dialog_start : MonoBehaviour {

	public GameObject kuriko;
	public Canvas Back;
	public Canvas Canvas1;
	public Canvas Canvas2;
	public Canvas Canvas3;
	public Canvas Canvas4;
	public GameObject Saje;
	int count=0;

	// Use this for initialization
	void Start () {
		Back.enabled = false;
		Canvas1.enabled = false;
		Canvas2.enabled = false;
		Canvas3.enabled = false;
		Canvas4.enabled = false;
		kuriko = GameObject.Find("KURIKO(2스테이지)");
	}
	
	// Update is called once per frame
	void Update () {

		if (kuriko.transform.position.x >= -36.25 && kuriko.transform.position.y >= 11.89
		   && kuriko.transform.position.x <= -32.86 && kuriko.transform.position.y <= 14.69) {

			if (Input.GetKeyDown (KeyCode.Space))
				count++;
			if (count == 0) {
				Back.enabled = true;
				Canvas1.enabled = true;
			} else if (count == 1) {
				Canvas1.enabled = false;
				Canvas2.enabled = true;
			} else if (count == 2) {
				Canvas2.enabled = false;
				Canvas3.enabled = true;
			} else if (count == 3) {
				Canvas3.enabled = false;
				Canvas4.enabled = true;
			} else if (count == 4) {
				Canvas4.enabled = false;
				Back.enabled = false;
				DestroyObject(Saje, 0.5f);
			}
			//if (Back.enabled == true) {

			//}

		}
	}
}
