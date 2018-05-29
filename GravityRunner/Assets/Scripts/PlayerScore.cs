using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
//using UnityEngine.Rendering.PostProcessing;

public class PlayerScore : MonoBehaviour {

    private Text scoreText;
    private int score = 0;

	void Awake ()
    {
        //gets the score text component and sets its text to 0
        scoreText = GameObject.Find("ScoreText").GetComponent<Text>();
        scoreText.text = "0";
	}

    void OnTriggerEnter2D(Collider2D target)
    {
        if(target.tag == "Colour")
        {
            score++;
            scoreText.text = score.ToString();
            target.gameObject.SetActive(false);
        } 
        if(target.tag == "Black")
        {
            transform.position = new Vector3(0, 1000, 0);
            target.gameObject.SetActive(false);
            StartCoroutine(RestartGame());
        }
    }

    IEnumerator RestartGame()
    {
        yield return new WaitForSecondsRealtime(2f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
