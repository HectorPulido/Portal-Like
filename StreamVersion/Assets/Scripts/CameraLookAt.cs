using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraLookAt : MonoBehaviour
{
    Transform target;
	// Use this for initialization
	void Start ()
    {
        target = GameObject.FindGameObjectWithTag("Player").transform;	
	}
	
	// Update is called once per frame
	void Update ()
    {
        transform.LookAt(target);	
	}
}
