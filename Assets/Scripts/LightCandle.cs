using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.VFX;

public class LightCandle : MonoBehaviour
{

    public InteractionManager imc;
    public TextMeshProUGUI LightCandleUIText;
    int CandleLit = 0;
    [SerializeField] VisualEffect lightCandle;
    public GameObject candleLight;

    void Start()
    {
       LightCandleUIText.gameObject.SetActive(false);
       candleLight.SetActive(false);
    }

    void Update()
    {
        
    }

    void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            if(CandleLit == 0)
            {
            print("Player Detected");
            LightCandleUIText.gameObject.SetActive(true); 
                if (Input.GetKey(KeyCode.E))
                {
                print("Pressed E");
                CandleLit++;
                LightCandleUIText.gameObject.SetActive(false); 
                imc.litCandles++;
                lightCandle.Play();
                candleLight.SetActive(true);
                }
            }    
        }
    }
    
    void OnTriggerExit(Collider other)
    {       
        LightCandleUIText.gameObject.SetActive(false); 
    }
}
