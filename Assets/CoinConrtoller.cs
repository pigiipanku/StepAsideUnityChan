﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinConrtoller : MonoBehaviour {

    private GameObject unitychan;
	// Use this for initialization
	void Start () {
        this.unitychan = GameObject.Find("unitychan");
        this.transform.Rotate(0,Random.Range(0,360),0);
		
	}
	
	// Update is called once per frame
	void Update () {
        this.transform.Rotate(0, 3, 0);
        if (this.unitychan.transform.position.z - this.transform.position.z >= 10)
        {
            Destroy(this.gameObject);
        }
	}
}
