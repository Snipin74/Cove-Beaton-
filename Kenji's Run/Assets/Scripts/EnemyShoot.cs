using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour {

    public float kenjiRange;
    public GameObject enemyStar;
    public PlayerController kenji;
    public Transform ThrowPoint;

    public float ThrowWaitTime;
    private float throwCounter;

	// Use this for initialization
	void Start () {
        kenji = FindObjectOfType<PlayerController>();
        throwCounter = ThrowWaitTime;
	}
	
	// Update is called once per frame
	void Update () {

       //this is how the boss sences the players distance and throws a ninja star that hurts the player 
        throwCounter -= Time.deltaTime;

        if(transform.localScale.x < 0 && kenji.transform.position.x > transform.position.x && kenji.transform.position.x < transform.position.x + kenjiRange && throwCounter < 0)
        {
            Instantiate(enemyStar, ThrowPoint.position, ThrowPoint.rotation);
            throwCounter = ThrowWaitTime;
        }

        if (transform.localScale.x > 0 && kenji.transform.position.x < transform.position.x && kenji.transform.position.x > transform.position.x - kenjiRange && throwCounter < 0)
        {
            Instantiate(enemyStar, ThrowPoint.position, ThrowPoint.rotation);
            throwCounter = ThrowWaitTime;
        }
    }
}
