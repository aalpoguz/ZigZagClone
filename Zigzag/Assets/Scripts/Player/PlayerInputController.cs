using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInputController : MonoBehaviour
{
    [HideInInspector] public Vector3 playerDirection;


    void Start()
    {
        playerDirection = Vector3.left;
    }

    // Update is called once per frame
    void Update()
    {
        HandleInputs();
    }


    private void HandleInputs()
    {
        if (Input.GetMouseButtonDown(0)) //Ekrana dokunulduğunda yön değiştirmesi - 0 mouse un sol tıkını ifade eder ama mobil alglar
        {
            ChangePlayerDirection();
        }
    }

    private void ChangePlayerDirection()
    {
        if (playerDirection.x == -1)
        {
            playerDirection = Vector3.forward;
        }
        else
        {
            playerDirection = Vector3.left;
        }

    }
}
