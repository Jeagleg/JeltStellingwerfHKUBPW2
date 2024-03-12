using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class StartRitual : MonoBehaviour
{

    public InteractionManager imr;
    public TextMeshProUGUI StartRitualUIText; 

    void Start()
    {
       StartRitualUIText.gameObject.SetActive(false);        
    }

    void Update()
    {

    }
        
    void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            print("Player In Circle");
            StartRitualUIText.gameObject.SetActive(true); 
            if (Input.GetKey(KeyCode.E))
            {
                print("Pressed E");            
                if (imr.litCandles == 5) 
                {
                    print("Ritual Starts");
                    StartRitualUIText.gameObject.SetActive(false);
                } 
            }
        }
    }
    
    void OnTriggerExit(Collider other)
    {       
        StartRitualUIText.gameObject.SetActive(false);       
    }
}

