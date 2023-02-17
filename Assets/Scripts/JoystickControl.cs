using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoystickControl : MonoBehaviour
{
    public GameObject Dron;
    public Transform topOfJoystick;

    [SerializeField]
    private float forwardBackwardTilt = 0;
    [SerializeField]
    private float sideToSideTilt = 0;

    private void Start()
    {

    }
    void Update()
    {
        forwardBackwardTilt = topOfJoystick.rotation.eulerAngles.x;
        if (forwardBackwardTilt < 355 && forwardBackwardTilt > 270)
        {
            forwardBackwardTilt = Mathf.Abs(forwardBackwardTilt - 360);
            Debug.Log("Backward" + forwardBackwardTilt);
            //Dron.GetComponent<Drone>().GoUp();
        }
        if (forwardBackwardTilt < 74 && forwardBackwardTilt > 5)
        {
            Debug.Log("Forward" + forwardBackwardTilt);
            Dron.GetComponent<Drone>().GoUp();
        }

        sideToSideTilt = topOfJoystick.rotation.eulerAngles.z;
        if (sideToSideTilt < 355 && sideToSideTilt > 290)
        {
            sideToSideTilt = Mathf.Abs(sideToSideTilt - 360);
            Dron.GetComponent<Drone>().TurnRight();
        }
        else if (sideToSideTilt > 5 && sideToSideTilt < 74)
        {
            Dron.GetComponent<Drone>().TurnLeft();
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if(other.CompareTag("PlayerHand"))
        {
            transform.LookAt(other.transform.position, transform.up);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("PlayerHand"))
        {
            transform.rotation = Quaternion.Euler(-90, 0, 90);
        }
    }
}
