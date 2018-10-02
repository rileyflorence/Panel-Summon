using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetScrubPosition : MonoBehaviour {
    public float scrubPosition;

	
	void Update()
    {
        
        //Bit shifting the layer mask number. Seems weird, but whatever.
        int layerMask = 1 << 9;
        Vector3 _relativeLoc;
        RaycastHit hit;

        Vector3 dwn = Vector3.down;

        //Casts a ray down from the associated game object.
        if (Physics.Raycast(transform.position, dwn, out hit, 1, layerMask))
        {
            //draw a line in the editor. Green if it hits the correct layer.
            Debug.DrawRay(transform.position, dwn * 1, Color.green);

            //Gets the hit location and then turns it's location relative to the hit object instead of being in worldspace.
            _relativeLoc = hit.transform.InverseTransformPoint(hit.point);

            //Get just the X value, then add 0.5 because the relative location starts at the center, but I want it to be from the edge.
            scrubPosition = _relativeLoc.x + 0.5f;
        

        }
        else
        {
            //Draw a debug ray in the editor that's red if it doesn't hit a valid layer.
            Debug.DrawRay(transform.position, dwn * 1, Color.red);
        }

    }
}
