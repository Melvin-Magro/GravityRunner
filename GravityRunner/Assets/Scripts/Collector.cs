using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collector : MonoBehaviour {

    //this variable will be used to get the width of the background
    private float width = 0f;

	// Use this for initialization
	void Awake ()
    {
        width = GameObject.Find("BG").GetComponent<BoxCollider2D>().size.x;		
	}
	
	void OnTriggerEnter2D(Collider2D target)
    {

		if(target.tag == "BG" || target.tag == "Ground")
        {
            //Once we hit the background or the ground tagged objects
            //we multiply the width value by 3 and reposition
            //background and ground in the new position
            //making it seem as if it has the infinite BG effect
            Vector3 temp = target.transform.position;
            temp.x += width * 3;
            target.transform.position = temp;
        }

        if(target.tag == "black" || target.tag =="colour")
        {
            target.gameObject.SetActive(false);
        }
	}
}
