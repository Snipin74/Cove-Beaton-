using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyStar : MonoBehaviour {

    public float speed;
    public float rotationSpeed;
    public int DamageAmount;

    public GameObject HitEffect;

    public PlayerController kenji;
    private Rigidbody2D myRigidbody2D;

	// Use this for initialization
	void Start () {
        kenji = FindObjectOfType<PlayerController>();

        myRigidbody2D = GetComponent<Rigidbody2D>();

        if(kenji.transform.position.x < transform.position.x)
        {
            speed = -speed;
            rotationSpeed = -rotationSpeed;
        }
	}
	
	// Update is called once per frame
	void Update () {
        myRigidbody2D.velocity = new Vector2(speed, myRigidbody2D.velocity.y);
        myRigidbody2D.angularVelocity = rotationSpeed;
	}


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.name == "Player")
        {
            HealthManager.health -= 20f;
            Destroy(gameObject);
        }
    }
}
