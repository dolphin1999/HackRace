using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSelector : MonoBehaviour {

	public GameObject car1;
	public GameObject car2;
	public GameObject car3;
	public GameObject car4;
	public GameObject car5;

	//public static int carSelected;


	void Start () {
		car1.SetActive (false);
		car2.SetActive (false);
		car3.SetActive (false);
		car4.SetActive (false);
		car5.SetActive (true);

		StartMenu.carSelected = 5;
	}

	public void load1() {
		car1.SetActive (true);
		car2.SetActive (false);
		car3.SetActive (false);
		car4.SetActive (false);
		car5.SetActive (false);

		StartMenu.carSelected = 1;
 
	}

	public void load2() {
		car1.SetActive (false);
		car2.SetActive (true);
		car3.SetActive (false);
		car4.SetActive (false);
		car5.SetActive (false);

		StartMenu.carSelected = 2;

	}

	public void load3() {
		car1.SetActive (false);
		car2.SetActive (false);
		car3.SetActive (true);
		car4.SetActive (false);
		car5.SetActive (false);

		StartMenu.carSelected = 3;

	}

	public void load4() {
		car1.SetActive (false);
		car2.SetActive (false);
		car3.SetActive (false);
		car4.SetActive (true);
		car5.SetActive (false);

		StartMenu.carSelected = 4;
	}

	public void load5() {
		car1.SetActive (false);
		car2.SetActive (false);
		car3.SetActive (false);
		car4.SetActive (false);
		car5.SetActive (true);

		StartMenu.carSelected = 5;
	}


}
