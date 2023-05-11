using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationOffset : MonoBehaviour
{
    public Transform target;
    public Vector3 rotationOffset;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        target.rotation = target.rotation * Quaternion.Euler(rotationOffset);
    }
}
