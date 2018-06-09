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
    Color c = new Color(0f, 1f, 1f, 0f);

    public RectTransform barLeft, barRight;

    private float speed = 7f;

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
            SceneManager.LoadScene("GameOver");
            //StartCoroutine(RestartGame());
             c.a -= 0.1f;
        }

        if(score % 10 == 0)
        {
            barLeft.localScale = barRight.localScale = new Vector3(Mathf.Floor((float) score / 10f), 1f, 1f);
            c.a = 0f;
        }

        overlay.color = c;
        Debug.Log(Mathf.Floor((float) score / 10f));

    }

    /* IEnumerator RestartGame()
    {
        yield return new WaitForSecondsRealtime(2f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    } */

}
