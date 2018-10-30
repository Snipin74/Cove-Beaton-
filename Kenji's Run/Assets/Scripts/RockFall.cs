using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockFall : MonoBehaviour {

    public static bool ground;
    private Rigidbody2D myRigidBody;
    public float fallDelay = 2.0f;

    enum GravityDirection { left, right, up, down };

    GravityDirection m_GravityDirection;


    // Use this for initialization
    void Start()
    {
        myRigidBody = GetComponent<Rigidbody2D>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        m_GravityDirection = GravityDirection.down;

    }
}
