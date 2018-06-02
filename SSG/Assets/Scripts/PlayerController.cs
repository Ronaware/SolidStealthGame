using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    ////////////////////////////////////////////////////////////////////////////////
    //
    // PLAYER CONTROLLER SCRIPT : THIS SCRIPT CONTAINS THE PLAYER'S CONTROL VALUES
    //                            AND MOVEMENT FUNCTIONS. 
    //
    // Author : Nathaniel Gonzales
    //
    ////////////////////////////////////////////////////////////////////////////////


    public MouseCameraController PlayerCam;

    public float moveSpeed = 5.0f;





    ////////////////////////////////////////////////////////////////////////////////

    // Use this for initialization
    void Start () {
		
	}// END START

    ///////////////////////////////

    // Update is called once per frame
    void Update () {

        // BASIC WASD CONTROLS

        if (Input.GetKey(KeyCode.W))            //  MOVE FORWARD
            transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed);

        if (Input.GetKey(KeyCode.A))            // MOVE LEFT
            transform.Translate(Vector3.left * Time.deltaTime * moveSpeed);

        if (Input.GetKey(KeyCode.S))            // MOVE BACKWARDS
            transform.Translate(Vector3.back * Time.deltaTime * moveSpeed);

        if (Input.GetKey(KeyCode.D))            // MOVE RIGHT
            transform.Translate(Vector3.right * Time.deltaTime * moveSpeed);

        ///////////////////////////////

        // ROTATES THE AVATAR

        if (Input.GetAxis("Mouse X") < 0)        // ROTATE LEFT
            transform.Rotate(Vector3.down); 

        if (Input.GetAxis("Mouse X") > 0)        // ROTATE RIGHT
            transform.Rotate(Vector3.up);

    }// END UPDATE






}// END SCRIPT
