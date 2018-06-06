using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {

    private float speed = 3f;

    private Button jumpBtn;

    private Rigidbody2D myBody;

    void Awake()
    {
        //jumpBtn = GameObject.Find("Jump").GetComponent<Button>();
        //jumpBtn.onClick.AddListener(() => Jump());
        myBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //moving the player on the x position by the amount 
        //allocated in the speed variable in real time (same speed as camera)
        Vector3 temp = transform.position;
        temp.x += speed * Time.deltaTime;
        transform.position = temp;

        if (Input.GetButtonDown("Jump"))
        {
            Jump();
        }
    }

    public void Jump()
    {
        myBody.gravityScale *= -1;
        Vector3 temp = transform.localScale;
        temp.y *= -1;
        transform.localScale = temp;

    }
}

