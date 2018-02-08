using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour {

	static public int carSelected = 5;
	public void Play()
	{
		SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 1);
	}

	public void Quit()
	{
		Application.Quit ();
	}

	public void CarSelect()
	{
		SceneManager.LoadScene (3);
	}

	public void back()
	{
		SceneManager.LoadScene (0);
	}


}
