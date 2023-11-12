using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [Header("The Camera's Target")]
    public Transform cameraTarget;

    // Update is called once per frame
    void Update()
    {
        if (cameraTarget.position.y > 0)
        {
            this.transform.position = new Vector3(0, cameraTarget.position.y, -10);
        }
        
    }
}
