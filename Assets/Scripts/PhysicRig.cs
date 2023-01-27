using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicRig : MonoBehaviour
{
    public Transform PlayerHead;
    public Transform LeftHand;
    public Transform RightHand;

    public CapsuleCollider BodyCollider;

    public ConfigurableJoint PlayerHeadJoint;
    public ConfigurableJoint LeftHandJoint;
    public ConfigurableJoint RightHandJoint;

    public float MinHeight = 0.5f;
    public float MaxHeight = 2;

    // Update is called once per frame
    void FixedUpdate(){
        BodyCollider.height = Mathf.Clamp(PlayerHead.localPosition.y, MinHeight, MaxHeight);
        BodyCollider.center = new Vector3(PlayerHead.localPosition.x, BodyCollider.height / 2, PlayerHead.localPosition.z);

        PlayerHeadJoint.targetPosition = PlayerHead.localPosition;
        LeftHandJoint.targetPosition = LeftHand.localPosition;
        RightHandJoint.targetPosition = RightHand.localPosition;

        LeftHandJoint.targetRotation = LeftHand.localRotation;
        RightHandJoint.targetRotation = RightHand.localRotation;
    
    }
}
