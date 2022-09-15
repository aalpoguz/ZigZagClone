using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowController : MonoBehaviour
{
    [SerializeField] private Transform playerTransform;
    private Vector3 offset; // arasındaki mesafeyi tutacak
    [SerializeField] [Range(0,3)] private float lerpValue;
    private Vector3 newPosition;

    private void Start()
    {
        offset = transform.position - playerTransform.position;
    }

    private void LateUpdate()
    {
        SetCameraSmootFollow();
    }

    private void SetCameraSmootFollow(){
        newPosition = Vector3.Lerp(transform.position, playerTransform.position + offset, lerpValue * Time.deltaTime); //kendi olduğu poziston, topun olduğu pozisyon 
        transform.position = newPosition;
    }
}
