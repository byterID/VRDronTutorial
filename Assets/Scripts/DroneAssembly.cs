using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DroneAssembly : MonoBehaviour
{
    public GameObject PropInPlace;
    public GameObject PropTrigger;

    private void Start()
    {

    }
    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Vert")
        {
            Destroy(other.gameObject);
            PropInPlace.SetActive(true);
            PropTrigger.SetActive(false);
        }
    }

}
