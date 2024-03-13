using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class StartRitual : MonoBehaviour
{

    public InteractionManager imr;
    public TextMeshProUGUI StartRitualUIText; 
    int ritualStarted = 0;

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
            if(ritualStarted == 0)
            {
                print("Player In Circle");
                if (imr.litCandles == 5) 
                {
                    StartRitualUIText.gameObject.SetActive(true);
                    if (Input.GetKey(KeyCode.E))
                    {
                    print("Ritual Starts");
                    StartRitualUIText.gameObject.SetActive(false);
                    ritualStarted++;
                    }
                }
            }
        }

        void OnTriggerExit(Collider other)
        {       
        StartRitualUIText.gameObject.SetActive(false);       
        }
    }
}

