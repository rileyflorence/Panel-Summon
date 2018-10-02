using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animController : MonoBehaviour {

    Animator animator;

    //I created an empty that's where the palm is of the right hand. This is a ref to that object.
    [SerializeField]
    GameObject hand;

    GetScrubPosition scrubPos;

	void Start () {
        animator = GetComponent<Animator>();
        scrubPos = hand.GetComponent<GetScrubPosition>();
    
	}
	
	void Update () {
        //Sets the animation frame.
        animator.Play("OpenMenu_ANIM", 0, scrubPos.scrubPosition);
	}
}
