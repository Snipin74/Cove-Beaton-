﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class JumpingShark : MonoBehaviour {

    //   [SerializeField] private float speed;

    //   public Transform target;
    //   public Transform target1;

    //   // Use this for initialization
    //   void Start () {

    //}

    //// Update is called once per frame
    //void Update () {

    //       float step = speed * Time.deltaTime;

    //       transform.position = Vector3.MoveTowards(transform.position, target.position, step);

    [SerializeField] private float speed;

    // The target marker.
    public Transform target;
    public Transform target1;
    public bool back = false;
    public Vector3 correctedPOS;


    void Update()
    {

        // The step size is equal to speed times frame time.
        float step = speed * Time.deltaTime;

        correctedPOS = target.position;
        correctedPOS.x -= 6.32f;

        if (transform.position == correctedPOS)
        {
            back = true;
        }
        correctedPOS = target1.position;
        correctedPOS.x -= 6.32f;

        if (transform.position == correctedPOS)
        {
            back = false;
        }

        // Move our position a step closer to the target.
        if (!back)
        {
            correctedPOS = target.position;
            correctedPOS.x -= 6.32f;

            transform.position = Vector3.MoveTowards(transform.position, correctedPOS, step);
        }
        else
        {
            correctedPOS = target1.position;
            correctedPOS.x -= 6.32f;

            transform.position = Vector3.MoveTowards(transform.position, correctedPOS, step);
        }

    }
}
