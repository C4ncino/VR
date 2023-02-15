using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class UI_Player : MonoBehaviour
{
    private bool onEndPoint;
    // * Panel Principal
    public GameObject playerUI;
    // * Textos
    public TMP_Text rightText;
    public TMP_Text leftText;
    // * Paneles de Advertencia
    public GameObject rightLight;
    public GameObject leftLight;
    
    public Transform puntoFinal;
    public Transform PlayerHead;

    public Color empty;
    public Color red;
    

    // Start is called before the first frame update
    void Start()
    {

        // onEndPoint = false;
        Debug.Log("Hola");
        // Renderer right = rightLight.GetComponent<Renderer>();
        // Renderer left = leftLight.GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        Image right = rightLight.GetComponent<Image>();
        Image left = leftLight.GetComponent<Image>();
        
        float headDeviation = PlayerHead.position.x;
        Debug.Log(headDeviation);
        if (headDeviation == 0){
            right.color = empty;
            left.color = empty;
            
            rightText.text = "";
            leftText.text = "";
        }
        else if (headDeviation < 0){
            right.color = empty;
            left.color = red;

            rightText.text = "";
            leftText.text = "Estás muy cerca de tu izquierda";
        }
        else if (headDeviation > 0){
            right.color = red;
            left.color = empty;

            rightText.text = "Estás muy cerca de tu derecha";
            leftText.text = "";
        }
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
