using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetScrubPosition : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	void FixedUpdate()

    {
        Vector3 dwn = transform.TransformDirection(Vector3.down);
        Debug.DrawRay(transform.position, dwn * 1, Color.green);

        if (Physics.Raycast(transform.position, dwn, 1))
            print("We found it!");

    }
}
