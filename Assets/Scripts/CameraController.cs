using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Camera cam;
    void Start()
    {
        cam = gameObject.GetComponent<Camera>();
        cam.aspect = 9f / 16f;
    }
}
