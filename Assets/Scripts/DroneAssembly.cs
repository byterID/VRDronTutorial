using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DroneAssembly : MonoBehaviour
{
    public GameObject[] Prop;
    public Transform[] props;
    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    public void OnCollisionEnter(Collision collision)
    {
        if(collision.transform.tag == "Prop1")
        {
            Prop[0].transform.position = props[0].transform.position;
            Prop[0].transform.SetParent(props[0]);
        }
        if (collision.transform.tag == "Prop2")
        {
            Prop[1].transform.position = props[1].transform.position;
            Prop[1].transform.SetParent(props[1]);
        }
        if (collision.transform.tag == "Prop3")
        {
            Prop[2].transform.position = props[2].transform.position;
            Prop[2].transform.SetParent(props[2]);
        }
        if (collision.transform.tag == "Prop4")
        {
            Prop[3].transform.position = props[3].transform.position;
            Prop[3].transform.SetParent(props[3]);
        }
    }

}
