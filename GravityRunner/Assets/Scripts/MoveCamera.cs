using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour {

    private float speed = 3f;
	
	// Update is called once per frame
	void Update ()
    {
        //moving the camera on the x position by the amount 
        //allocated in the speed variable in real time
        Vector3 temp = transform.position;
        temp.x += speed * Time.deltaTime;
        transform.position = temp;
	}
}
