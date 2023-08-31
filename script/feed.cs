using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class feed : MonoBehaviour {
	public GameObject bank_soal,skor;
	// Use this for initialization
	void Start () {
		
	}

	public void feedback(){
		bank_soal.GetComponent<bank_soal> ().control (1);
		if (gameObject.name == "benar") {
			skor.GetComponent<skor> ().score += 10;
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
