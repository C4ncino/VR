using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;      

public class TestingInputSystem : MonoBehaviour
{
    private Rigidbody Player;
    public float MovementSpeed;

    // Start is called before the first frame update
    private void Start(){
        Player = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    private void Update(){
        
    }

    public void Right (InputAction.CallbackContext context) {
        if(context.performed){
            Debug.Log("Right Step");
            Player.AddForce(Vector3.forward * MovementSpeed, ForceMode.Impulse);
        }
    }
    
    public void Left (InputAction.CallbackContext context) {
        if(context.performed){
            Debug.Log("Left Step");
            Player.AddForce(Vector3.forward * MovementSpeed, ForceMode.Impulse);
        }
    }
}
