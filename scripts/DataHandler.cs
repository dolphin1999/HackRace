using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataHandler : MonoBehaviour {

	//public int carSelected;

	/*void Awake(){
		DontDestroyOnLoad (this.gameObject);
	}*/

	void Start () {
		StartMenu.carSelected = 5;
	}
	

	public void selector (int a) {
		StartMenu.carSelected = a;
	}
}
