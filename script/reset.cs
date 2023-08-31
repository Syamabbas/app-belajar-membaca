using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class reset : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	public void reset_game(){
		Application.LoadLevel (Application.loadedLevelName);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
