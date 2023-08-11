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
    public TMP_Text distanceText;
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

        onEndPoint = false;
        Debug.Log("Hola");
        Debug.Log(rightText.text);
        Debug.Log(leftText.text);

    }

    // Update is called once per frame
    void Update()
    {
        Image right = rightLight.GetComponent<Image>();
        Image left = leftLight.GetComponent<Image>();
        
        float headDeviation = PlayerHead.position.x;
        //Debug.Log(headDeviation);
        if (headDeviation > 0.5){
            right.color = empty;
            left.color = red;

            rightText.text = "";
            leftText.text = "Estás muy cerca de tu izquierda";
        }
        else if (headDeviation < -0.5){
            right.color = red;
            left.color = empty;

            rightText.text = "Estás muy cerca de tu derecha";
            leftText.text = "";
        }
        else {
            right.color = empty;
            left.color = empty;

            rightText.text = "";
            leftText.text = "";
        }

        if (!onEndPoint)
        {
            float dist = Vector3.Distance(puntoFinal.position, this.transform.position);
            int distExacta = (int)dist;
            distanceText.text = distExacta.ToString() + " metros";
        }
        else
        {
            distanceText.text = " ";
            // SceneManager.LoadScene("SampleScene");
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "PuntoFinal")
        {
            onEndPoint = true;
        }
        else
        {
             onEndPoint = false;
        }
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
