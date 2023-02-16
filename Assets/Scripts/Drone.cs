using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drone : MonoBehaviour
{
    public float MoveSpeed = 10f;
    public float SpeedRotation = 10f;

    Rigidbody rb;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    public void GoUp()
    {
        rb.AddRelativeForce(0, MoveSpeed * Time.deltaTime, 0);
    }
    public void TurnLeft()
    {
        transform.Rotate(0, -SpeedRotation * Time.deltaTime, 0);
    }
    public void TurnRight()
    {
        transform.Rotate(0, SpeedRotation * Time.deltaTime, 0);
    }
}
