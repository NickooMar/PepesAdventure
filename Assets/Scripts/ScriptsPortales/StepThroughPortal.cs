using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StepThroughPortal : MonoBehaviour
{

    public GameObject otherPortal;

    void OnTriggerEnter(Collider other) {
        Debug.Log("Something hit the portal");
        if(other.tag == "Player" || other.tag == "CubitoRigidBody") {
            other.transform.position = otherPortal.transform.position + otherPortal.transform.forward * 2f;
        }
    }


}
