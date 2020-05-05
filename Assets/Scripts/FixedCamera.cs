using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Sets the camera at a static rotation so that it does not rotate with the player.
/// </summary>
public class FixedCamera : MonoBehaviour
{
    public float cameraHeight = 7.16f;
    Vector3 position;
    Transform playerTransform;
    // Start is called before the first frame update
    void Start()
    {
        playerTransform = GameObject.FindWithTag("Player").transform;
    }

    // FixedUpdate is called several times per frame
    void FixedUpdate()
    {
        Vector3 cameraPosition = playerTransform.position;
        cameraPosition.y = cameraHeight;
        cameraPosition.z -= 5.0f;
        this.transform.position = cameraPosition;
    }
}
