using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class skor : MonoBehaviour {
	public GameObject skor_akhir;
	public int score;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		GetComponent<Text> ().text = score.ToString();
		skor_akhir.GetComponent<Text> ().text = score.ToString ();
	}
}
