using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animController : MonoBehaviour {

    Animator animator;

    [SerializeField]
    GameObject hand;

    GetScrubPosition scrubPos;

	// Use this for initialization
	void Start () {
        animator = GetComponent<Animator>();
        scrubPos = hand.GetComponent<GetScrubPosition>();
    
	}
	
	// Update is called once per frame
	void Update () {
        animator.Play("OpenMenu_ANIM", 0, scrubPos.scrubPosition);
	}
}
