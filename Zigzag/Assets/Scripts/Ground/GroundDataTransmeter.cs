using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundDataTransmeter : MonoBehaviour
{
    [SerializeField] private GroundFallController groundFallController;

    public void SetGroundRigidBodyValues(){
        StartCoroutine(groundFallController.SetRigidBodyValues());
    }
}
