using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForkLiftController : MonoBehaviour
{
    [SerializeField] WheelCollider leftBack;
    [SerializeField] WheelCollider leftFront;
    [SerializeField] WheelCollider rightBack;
    [SerializeField] WheelCollider rightFront;

    public float speed = 100f;
    public float brakeForce = 100f;

    private float currentSpeed = 0f;
    private float currentBrakeForce = 0f;

    private void FixedUpdate()
    {
        
        float moveInput = Input.GetAxis("Vertical");
        float turnInput = Input.GetAxis("Horizontal");
        
        currentSpeed = moveInput * speed;
        leftFront.motorTorque = currentSpeed;
        rightFront.motorTorque = currentSpeed;
        leftBack.motorTorque = currentSpeed;
        rightBack.motorTorque = currentSpeed;
        
        leftFront.steerAngle = turnInput * 15f; 
        rightFront.steerAngle = turnInput * 15f;
       
        if (Input.GetKey(KeyCode.Space))
        {
            currentBrakeForce = brakeForce;
            leftFront.brakeTorque = currentBrakeForce;
            rightFront.brakeTorque = currentBrakeForce;
            leftBack.brakeTorque = currentBrakeForce;
            rightBack.brakeTorque = currentBrakeForce;
        }
        else
        {
            currentBrakeForce = 0f;
            leftFront.brakeTorque = 0f;
            rightFront.brakeTorque = 0f;
            leftBack.brakeTorque = 0f;
            rightBack.brakeTorque = 0f;
        }
    }





}
