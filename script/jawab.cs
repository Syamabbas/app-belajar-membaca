using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jawab : MonoBehaviour {
	public GameObject meletus, gelembung, feedbenar, feedsalah;
	public bool benar;
	// Use this for initialization
	void Start () {
		
	}

	void OnMouseUp(){
		meletus.SetActive (true);
		gelembung.SetActive (true);

		if (benar) {
			feedbenar.SetActive (false);
			feedbenar.SetActive (true);
		} else {
			feedsalah.SetActive (false);
			feedsalah.SetActive (true);
		}



		Destroy (gameObject);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
