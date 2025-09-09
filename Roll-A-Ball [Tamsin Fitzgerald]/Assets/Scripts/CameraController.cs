using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;
    Vector3 distanceBeteenCamerAndPlayer;

    private void Start()
    {
        distanceBeteenCamerAndPlayer = transform.position - player.transform.position;

    }

    private void LateUpdate()
    {
        transform.position = player.transform.position + distanceBeteenCamerAndPlayer;
    }
}
