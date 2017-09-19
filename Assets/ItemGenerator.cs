﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemGenerator : MonoBehaviour {
    public GameObject carPrefab;
    public GameObject coinPrefab;
    public GameObject conePrefab;
    private int startPos = -160;
    private int goalPos = 120;
    private float PosRange = 3.4f;
    private GameObject unitychan;
    private GameObject Car;
    private GameObject Cone;
    private GameObject Coin;
    // Use this for initialization
    void Start () {
        this.unitychan = GameObject.Find("unitychan");
        for (int i = startPos; i < goalPos; i += 15)
        {
            int num = Random.Range(0, 10);
            if (num <= 1)
            {
                for (float j = -1; j <= 1; j += 0.4f)
                {
                    GameObject cone = Instantiate(conePrefab) as GameObject;
                    cone.transform.position = new Vector3(4 * j, cone.transform.position.y, i);
                }
            }
            else
            {
                for (int j = -1; j < 2; j++)
                {
                    int item = Random.Range(1, 11);
                    int offsetZ = Random.Range(-5, 6);
                    if (1 <= item && item <= 6)
                    {
                        GameObject coin = Instantiate(coinPrefab) as GameObject;
                        coin.transform.position = new Vector3(this.PosRange * j, coin.transform.position.y, i + offsetZ);
                    }
                    else if (7 <= item && item <= 10)
                    {
                        GameObject car = Instantiate(carPrefab) as GameObject;
                        car.transform.position = new Vector3(this.PosRange * j, car.transform.position.y, i + offsetZ);
                    }
                }
            }
            
        }
        this.Car = GameObject.Find("CarPrefab(Clone)");
        this.Cone=GameObject.Find("TrafficConePrefab(Clone)");
        this.Coin = GameObject.Find("CoinPrefab(Clone)");
	}
	
	// Update is called once per frame
        void Update()
        {
            if (this.unitychan.transform.position.z - this.Car.transform.position.z >= 10)
            {
                Destroy(this.Car);
            }
            if (this.unitychan.transform.position.z - this.Cone.transform.position.z >= 10)
            {
                Destroy(this.Cone);
            }
            if (this.unitychan.transform.position.z - this.Coin.transform.position.z == 10)
            {
                Destroy(this.Coin);
            }


        }
}
