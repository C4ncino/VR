using System.Collections;
using System.Collections.Generic;
using System.IO.Ports;
using UnityEngine;

public class MovementInput : MonoBehaviour
{
    public string portName;
    public int baudRate;
    public string msg;
    private SerialPort serialPort;
    // Start is called before the first frame update
    void Start()
    {
        serialPort = new SerialPort(portName, baudRate);
        serialPort.Open();
        serialPort.ReadTimeout = 100;
    }

    // Update is called once per frame
    void Update()
    {
        if (serialPort.IsOpen){
            serialPort.Write(msg);
            Debug.Log(msg);
        }
        
    }
}
