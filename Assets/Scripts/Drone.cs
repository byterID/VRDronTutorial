using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drone : MonoBehaviour
{
    public float MoveSpeed = 1000f;
    public float SpeedRotation = 10f;

    Rigidbody rb;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    public void GoUp()
    {
        rb.AddRelativeForce(Vector3.forward * MoveSpeed * Time.deltaTime, ForceMode.Impulse);
        //transform.localPosition += new Vector3(0.5f,0,0);
    }
    public void TurnLeft()
    {
        transform.Rotate(0, 0, -SpeedRotation * Time.deltaTime);
    }
    public void TurnRight()
    {
        transform.Rotate(0, 0, SpeedRotation * Time.deltaTime);
    }
    public void GoForward()
    {
        
        rb.AddRelativeForce(Vector3.up * MoveSpeed, ForceMode.Impulse);
    }
    public void GoBackward()
    {
        rb.AddRelativeForce(Vector3.up * -MoveSpeed * Time.deltaTime, ForceMode.Impulse);
    }
    public void GoRight()
    {
        rb.AddRelativeForce(Vector3.right * MoveSpeed * Time.deltaTime, ForceMode.Impulse);
    }
    public void GoLeft()
    {
        rb.AddRelativeForce(Vector3.left * MoveSpeed * Time.deltaTime, ForceMode.Impulse);
    }
}
