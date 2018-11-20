using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {

    public Rigidbody rb;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey("d")){
            rb.AddForce(500 * Time.deltaTime, 0, 0);
        }
        else if (Input.GetKey("a"))
        {
            rb.AddForce(-(500 * Time.deltaTime), 0, 0);
        }
        else if (Input.GetKey("s"))
        {
            rb.AddForce(0,0, -(500 * Time.deltaTime));
        }
        else if (Input.GetKey("w"))
        {
            rb.AddForce(0, 0, 500 * Time.deltaTime);
        }
    }

    // Update id called once per frame but it's better to use "FixedUpdate" when we mess arround with UnityPhysics
    void FixedUpdate ()
    {

    }
}
