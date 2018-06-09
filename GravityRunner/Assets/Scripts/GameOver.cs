using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameOver : MonoBehaviour {

	[SerializeField]
    private GameObject[] items;
	// Use this for initialization
	public void Restart()
	{
		SceneManager.LoadScene("MainScene");
	}

	public void Quit()
	{
		Application.Quit();
	}
}
