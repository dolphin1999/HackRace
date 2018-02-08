using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Window3 : MonoBehaviour {

	public void PlayAgain()
	{
		SceneManager.LoadScene (1);
	}

	public void Quit()
	{
		Application.Quit ();
	}

}
