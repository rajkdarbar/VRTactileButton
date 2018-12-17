﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Leap.Unity;
using Leap.Unity.Interaction;

public class buttonTouchInteraction : MonoBehaviour {

    KeyboardInteraction parentKeyboard;
    private int colliders;
    private float delay = 0;

    void Start()
    {
        parentKeyboard = transform.parent.gameObject.GetComponent<KeyboardInteraction>();
    }

    void Update () {

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (colliders == 0)
        {
            gameObject.GetComponent<Renderer>().material.color = Color.red;
        }
        colliders++;
    }

    private void OnCollisionExit(Collision collision)
    {
        colliders--;
        if (colliders == 0)
        {
            gameObject.GetComponent<Renderer>().material.color = Color.black;
            parentKeyboard.childClick(this.gameObject);
        }

    }
}