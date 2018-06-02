using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatrolWaypoint : MonoBehaviour {

    [SerializeField]
    protected float debugDrawRadius = 1.0f;



	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public virtual void OnDrawGizmos()
    {

        Gizmos.color = Color.red;                                   // Shows up Red in when Gizmos tab is pressed   
        Gizmos.DrawWireSphere(transform.position, debugDrawRadius); // Wire sphere is projected when Gizmos tab is pressed

    }


}
