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
        Debug.DrawLine(new Vector3(transform.position.x - kenjiRange, transform.position.y, transform.position.z), new Vector3 (transform.position.x + kenjiRange, transform.position.y, transform.position.z));
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
