using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bank_soal : MonoBehaviour {
	public GameObject hasil_bermain;
	int urutan = 0;
	// Use this for initialization
	void Start () {
		set_balon ();
	}

	public void control(int i){
		if (urutan < transform.childCount-1) {
			urutan += i;
		} else {
			hasil_bermain.SetActive (true);
		}
		set_balon ();
	}

	public void set_balon(){
		for (int i = 0; i < transform.childCount; i++) {
			transform.GetChild (i).gameObject.SetActive (false);
		}
		transform.GetChild (urutan).gameObject.SetActive (true);
	}

	// Update is called once per frame
	void Update () {
		
	}
}
