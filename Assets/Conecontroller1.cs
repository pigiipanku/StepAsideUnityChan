using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conecontroller1 : MonoBehaviour {

    private GameObject unitychan;
    // Use this for initialization
    void Start()
    {
        this.unitychan = GameObject.Find("unitychan");

    }

    // Update is called once per frame
    void Update()
    {
        if (this.unitychan.transform.position.z - this.transform.position.z >= 10)
        {
            Destroy(this.gameObject);
        }
    }
}
