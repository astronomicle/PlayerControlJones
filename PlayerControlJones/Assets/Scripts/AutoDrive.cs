using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoDrive : MonoBehaviour
{
    private float speed = 10.0f;

    void Start()
    {
        
    }

    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
