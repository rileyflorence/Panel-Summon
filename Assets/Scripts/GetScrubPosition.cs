using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetScrubPosition : MonoBehaviour {
    public float scrubPosition;

	// Use this for initialization
	void Start () {
		
	}
	
	void Update()
    {
        
        int layerMask = 1 << 9;
        Vector3 _relativeLoc;
        RaycastHit hit;

        Vector3 dwn = Vector3.down;

        if (Physics.Raycast(transform.position, dwn, out hit, 1, layerMask))
        {
            Debug.DrawRay(transform.position, dwn * 1, Color.green);
            _relativeLoc = hit.transform.InverseTransformPoint(hit.point);
            scrubPosition = _relativeLoc.x + 0.5f;
        

        }
        else
        {
            Debug.DrawRay(transform.position, dwn * 1, Color.red);
        }

    }
}
