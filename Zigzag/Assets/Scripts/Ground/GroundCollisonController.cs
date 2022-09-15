using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCollisonController : MonoBehaviour
{   
    [SerializeField] private GroundDataTransmeter groundDataTransmeter;
    private void OnCollisionExit(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            groundDataTransmeter.SetGroundRigidBodyValues();
        }
    }
}
