﻿using UnityEngine;
using System.Collections;


public class shipExplode : MonoBehaviour {

    Animator anim;

    // Use this for initialization
    void Start () {
        anim = GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update () {
        anim.SetInteger("State", 1);
	}
}
