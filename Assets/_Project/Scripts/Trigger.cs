using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Object has entered the trigger");
        other.GetComponent<Rigidbody>().AddForce(new Vector3(0, 5, 0), ForceMode.VelocityChange);
    }

    private void OnTriggerStay(Collider other)
    {
        Debug.Log("Object is inside trigger");
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Object has exited the trigge");
    }
}
