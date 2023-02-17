using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchCamera : MonoBehaviour
{
    private Camera myCamera;

    void Start()
    {
        myCamera = GetComponent<Camera>();
    }

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            myCamera.enabled = !myCamera.enabled;
        }
    }
}
