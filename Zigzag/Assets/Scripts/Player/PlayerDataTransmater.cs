using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDataTransmater : MonoBehaviour
{
   
    [SerializeField] private PlayerInputController playerInputController;

    public Vector3 GetPlayerDirection(){
        return playerInputController.playerDirection;
    }
}
