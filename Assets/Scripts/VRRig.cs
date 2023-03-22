using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class VRMap
{
    public Transform vrTarget;
    public Transform rigTarget;
    public Vector3 trackingPositionOffset;
    public Vector3 trackingRotationOffset;

    public void Map(){
        rigTarget.position = vrTarget.TransformPoint(trackingPositionOffset);
        rigTarget.rotation = vrTarget.rotation * Quaternion.Euler(trackingRotationOffset);
    }
}

public class VRRig : MonoBehaviour
{
    public VRMap head;
    public VRMap leftHand;
    public VRMap rightHand;

    public Transform headConstraint;
    public Transform Body;
    public Vector3 headBodyOffset;
    // Start is called before the first frame update
    void Start()
    {
        headBodyOffset = Body.position - headConstraint.position;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Body.position = headConstraint.position + headBodyOffset;
        Body.forward = -1 * Vector3.ProjectOnPlane(headConstraint.up, Vector3.up).normalized;

        head.Map();
        leftHand.Map();
        rightHand.Map();
    }
}
