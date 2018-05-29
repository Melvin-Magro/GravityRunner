using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.PostProcessing;

public class PlayerScore : MonoBehaviour {

    private Text scoreText;
    private int score = 0;
    public Image overlay;
    Color c = new Color(1f, 0f, 0f, 0f);

	void Awake ()
    {
        //gets the score text component and sets its text to 0
        scoreText = GameObject.Find("ScoreText").GetComponent<Text>();
        scoreText.text = "0";

        //PostProcessingBehaviour ppb = GameObject.FindObjectOfType<PostProcessingBehaviour>();
        //ppb.profile.colorGrading.enabled = true;

        overlay.color = c;
	}

    void OnTriggerEnter2D(Collider2D target)
    {
        if(target.tag == "Colour")
        {
            score++;
            scoreText.text = score.ToString();
            target.gameObject.SetActive(false);
            c.a += 0.1f;
        } 
        if(target.tag == "Black")
        {
            transform.position = new Vector3(0, 1000, 0);
            target.gameObject.SetActive(false);
            StartCoroutine(RestartGame());
        }
        overlay.color = c;
    }

    IEnumerator RestartGame()
    {
        yield return new WaitForSecondsRealtime(2f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
