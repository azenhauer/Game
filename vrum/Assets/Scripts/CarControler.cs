using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//code from: https://www.youtube.com/watch?v=Z4HA8zJhGEk
public class CarController : MonoBehaviour
{
    private const string HORIZONTAL = "Horizontal";
    private const string VERTICAL = "Vertical";
    private float horizontalInput;
    private float verticalInput;
    private bool isBreaking;
    [SerializeField] private WheelCollider rFrontW;
    [SerializeField] private WheelCollider lFrontW;
    [SerializeField] private WheelCollider rRearW;
    [SerializeField] private WheelCollider lRearW;
   
   
   
    [SerializeField] private Transform rFrontWTransform;
    [SerializeField] private Transform lFrontWTransform;
    [SerializeField] private Transform rRearWTransform;
    [SerializeField] private Transform lRearWTransform;


    private float motorForce = 3000f;
    private float breakForce = 1000f;
    private float currentBreak;
    private float maxSteering = 30;

    private void FixedUpdate()
    {
        GetInput();
        HandleMotor();
        HandleSteering();
        UpdateWheels();
    }

    private void GetInput()
    {
        horizontalInput = Input.GetAxis(HORIZONTAL);
        verticalInput = Input.GetAxis(VERTICAL);
        isBreaking = Input.GetKey(KeyCode.Space); 
    }

    private void HandleMotor()
    {
        rFrontW.motorTorque = verticalInput * motorForce;
        lFrontW.motorTorque = verticalInput * motorForce;
        if (isBreaking)
        {
            currentBreak = breakForce;
            
        }
        else
        {
            currentBreak = 0f;
        }
        ApplyBreaking();
    }

    private void ApplyBreaking()
    {
        rFrontW.brakeTorque = currentBreak;
        lFrontW.brakeTorque = currentBreak;
        rRearW.brakeTorque = currentBreak;
        lRearW.brakeTorque = currentBreak;
    }

    private void HandleSteering()
    {
        float currentSteering = maxSteering * horizontalInput;
        rFrontW.steerAngle = currentSteering;
        lFrontW.steerAngle = currentSteering;
    }

    private void UpdateWheels()
    {
       UpdateSingleWheel(rFrontW, rFrontWTransform);
       UpdateSingleWheel(lFrontW, lFrontWTransform);
       UpdateSingleWheel(rRearW, rRearWTransform);
       UpdateSingleWheel(lRearW, lRearWTransform);
    }
    private void UpdateSingleWheel(WheelCollider wheelCollider, Transform wheelTransform){

        Vector3 pos;
        Quaternion rot;
        wheelCollider.GetWorldPose(out pos, out rot);
        wheelTransform.rotation = rot;
        wheelTransform.position = pos;

    }
}
