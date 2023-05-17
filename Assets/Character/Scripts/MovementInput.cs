// using System.Collections;
// using System.Collections.Generic;
// using System.IO.Ports;
// using UnityEngine;

// public class MovementInput : MonoBehaviour
// {
//     public string portName;
//     public int baudRate;
//     private SerialPort serialPort;
//     // Start is called before the first frame update
//     void Start()
//     {
//         serialPort = new SerialPort(portName, baudRate);
//     }

//     // Update is called once per frame
//     void Update()
//     {
//         if (serialPort.IsOpen){
//             serialPort.Write("A");
//             Debug.Log("A");
//         }
        
//     }
// }
