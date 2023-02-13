using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class UI_Player : MonoBehaviour
{
    private bool onEndPoint;
    public GameObject player_UI;
    public TMP_Text right_Text;
    public TMP_Text left_Text;
    public Transform puntoFinal;
    public Transform PlayerHead;

    // Start is called before the first frame update
    void Start()
    {
        onEndPoint = false;
        Debug.Log("Hola");
    }

    // Update is called once per frame
    void Update()
    {
        
        float A = PlayerHead.position.x;
        Debug.Log(A);
        // if (!onEndPoint)
        // {
        //     float dist = Vector3.Distance(puntoFinal.position, this.transform.position);
        //     int distExacta = (int)dist;
        //     distanciaTexto.text = distExacta.ToString() + " metros";
        //     panelIndicaciones.SetActive(true);
        // }
        // else
        // {
        //     distanciaTexto.text = " ";
        //     panelIndicaciones.SetActive(false);
        //     // SceneManager.LoadScene("SampleScene");
        // }
    }

    private void OnCollisionEnter(Collision collision)
    {
        // if(collision.gameObject.name == "PuntoFinal")
        // {
        //     onEndPoint = true;
        // }
        // else
        // {
        //     onEndPoint = false;
        // }
    }
    /*
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "PuntoFinal")
        {
            onEndPoint = true;
        }
    }
    */
}
