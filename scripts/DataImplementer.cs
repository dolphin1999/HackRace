using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataImplementer : MonoBehaviour {

	public GameObject car1;
	public GameObject car2;
	public GameObject car3;
	public GameObject car4;
	public GameObject car5;

	//public int CarSelected = GameObject.Find("DataHandler").GetComponent<DataHandler>().carSelected;
	//private CarSelecter CarObj;
	//public int CarSelected = StartMenu.carSelected;
	void Start () {

		if (StartMenu.carSelected == 1) {
			car1.SetActive (true);
			car2.SetActive (false);
			car3.SetActive (false);
			car4.SetActive (false);
			car5.SetActive (false);

		} else if (StartMenu.carSelected == 2) {
			car1.SetActive (false);
			car2.SetActive (true);
			car3.SetActive (false);
			car4.SetActive (false);
			car5.SetActive (false);


		} else if (StartMenu.carSelected == 3) {
			car1.SetActive (false);
			car2.SetActive (false);
			car3.SetActive (true);
			car4.SetActive (false);
			car5.SetActive (false);
		} else if (StartMenu.carSelected == 4) {
			car1.SetActive (false);
			car2.SetActive (false);
			car3.SetActive (false);
			car4.SetActive (true);
			car5.SetActive (false);
		} else if (StartMenu.carSelected == 5) {
			car1.SetActive (false);
			car2.SetActive (false);
			car3.SetActive (false);
			car4.SetActive (false);
			car5.SetActive (true);
		}

			
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
