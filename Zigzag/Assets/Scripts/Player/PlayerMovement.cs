using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private PlayerDataTransmater playerDataTransmater;

    [SerializeField] private float playerSpeed;

    private void Update()
    {
        SetPlayerMovement();
    }

    private void SetPlayerMovement() 
    {
        //topun hareketi
        transform.position += playerDataTransmater.GetPlayerDirection() * playerSpeed * Time.deltaTime;
    }
}
