using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseCameraController : MonoBehaviour {

    ////////////////////////////////////////////////////////////////////////////////
    //
    // MOUSECAMERACONTROLLER : THIS SCRIPT CONTAINS THE PLAYER'S CAMERA CONTROLS 
    //
    // Author : Nathaniel Gonzales
    //
    ////////////////////////////////////////////////////////////////////////////////


    public float speedH = 2.0f;
    public float speedV = 2.0f;

    private float yaw = 0.0f;
    private float pitch = 0.0f;

    ////////////////////////////////////////////////////////////////////////////////
    // Use this for initialization
    void Start()
    {

        

}// END START
    ////////////////////////////////////////////////////////////////////////////////



    ////////////////////////////////////////////////////////////////////////////////
    void Update()
    {
        yaw += speedH * Input.GetAxis("Mouse X");               // Camera Moves Left and Right
       // pitch -= speedV * Input.GetAxis("Mouse Y");           // Camera Moves Up and Down
        transform.eulerAngles = new Vector3(pitch, yaw, 0.0f);  
        
        ///////////////////////////////          ///////////////////////////////

        

        //if (Input.GetAxis("Mouse X") < 0)
        //    transform.Rotate(Vector3.down);

        //if (Input.GetAxis("Mouse X") > 0)
        //    transform.Rotate(Vector3.up);



    }// END UPDATE
     ////////////////////////////////////////////////////////////////////////////////





    ////////////////////////////////////////////////////////////////////////////////
}// END SCRIPT
