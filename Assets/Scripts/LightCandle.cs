using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LightCandle : MonoBehaviour
{

    public InteractionManager imc;
    public TextMeshProUGUI LightCandleUIText;

    void Start()
    {
       LightCandleUIText.gameObject.SetActive(false); 
    }

    void Update()
    {
        
    }

    void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            print("Player Detected");
            LightCandleUIText.gameObject.SetActive(true); 
            if (Input.GetKey(KeyCode.E))
            {
                print("Pressed E");
                Destroy(this.gameObject);
                LightCandleUIText.gameObject.SetActive(false); 
                imc.litCandles++;
            }
        }
    }
    
    void OnTriggerExit(Collider other)
    {       
        LightCandleUIText.gameObject.SetActive(false); 
    }
}
