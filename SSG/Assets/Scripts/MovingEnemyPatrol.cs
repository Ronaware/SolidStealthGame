using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MovingEnemyPatrol : MonoBehaviour {

    ////////////////////////////////////////////////////////////////////////////////
    //
    // MovingEnemyPatrol : THIS SCRIPT CONTAINS THE PATROL ROUTE OF MOVING ENEMIES
    //
    // Author : Nathaniel Gonzales
    //
    ////////////////////////////////////////////////////////////////////////////////

    [SerializeField]
    Transform _destination;

    NavMeshAgent _navMeshAgent;



    ////////////////////////////////////////////////////////////////////////////////

    // Use this for initialization
    void Start () {

        _navMeshAgent = this.GetComponent<NavMeshAgent>();

        if (_navMeshAgent == null)
        {
            Debug.LogError("Nav mesh is not attached to" + gameObject.name);
        }
        else
        {
            SetDestination();
        }
    } // End Start

    ////////////////////////////////////////////////////////////////////////////////

    private void SetDestination()
    {

        if(_destination != null)
        {
            Vector3 targetVector = _destination.transform.position;
            _navMeshAgent.SetDestination(targetVector);
        }
    } // End SetDesintation

    ////////////////////////////////////////////////////////////////////////////////

    // Update is called once per frame
    void Update () {
		


	}// End Update

    ////////////////////////////////////////////////////////////////////////////////

} // End Script
