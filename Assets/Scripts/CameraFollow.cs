using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
   
   public Transform followtarget;

   public float smoothTime = 0.3f;

   private Vector3 velocity = Vector3.zero;
   
   
   
   
    void LateUpdate()
    {
        Vector3 targetPosition = followtarget.position;
        targetPosition.z = transform.position.z;

        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime);
    }

    
    public void SwitchCameraTargets(Transform newCameraTarget)
    {
        followtarget = newCameraTarget;
    }
}
