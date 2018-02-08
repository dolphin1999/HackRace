using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Speed : MonoBehaviour {

	public static float speed = 0.0f;
	public WheelCollider wheel;
	public GameObject speedBox;

	void Update () {
		
		speed = (Mathf.PI * 2 * wheel.radius) * wheel.rpm * 60 / 1000;
		speed = Mathf.Round(speed);
		speedBox.GetComponent<Text> ().text = "" + speed;
	}
}
