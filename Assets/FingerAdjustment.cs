using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FingerAdjustment : MonoBehaviour
{

    public Transform Wrist;
    public Transform Hint;
    private Vector3 DifferenceTargetHint;

    // Start is called before the first frame update
    void Start()
    {
        DifferenceTargetHint =  Hint.position - Wrist.position;
    }

    // Update is called once per frame
    void Update()
    {
        Hint.position = Wrist.position + DifferenceTargetHint;        
        DifferenceTargetHint =  Hint.position - Wrist.position;
    }
}
