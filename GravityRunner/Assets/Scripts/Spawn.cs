using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour {


    [SerializeField]
    private GameObject[] items;

    private float minY = -2.5f, maxY = 2.5f; 


	
	void Start ()
    {
        //used for initialization of the loop to spawn the items
        StartCoroutine(SpawnItems(1f));
    }
	
	IEnumerator SpawnItems(float time)
    {
        //after waiting for 1 or 2 seconds, we spawn an item on the Y position randomly 
        //between the minY, maxY and instantiate a new game object which is going to be
        //either a black drop (the enemy) or colour drop(the collectible)
        yield return new WaitForSecondsRealtime (time);
        Vector3 temp = new Vector3(transform.position.x, Random.Range(minY, maxY));
        Instantiate(items[Random.Range(0, items.Length)], temp, Quaternion.identity);
        StartCoroutine(SpawnItems(Random.Range(1f, 2f)));
    }
}
