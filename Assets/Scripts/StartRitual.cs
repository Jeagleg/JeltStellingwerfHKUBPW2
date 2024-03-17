using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class StartRitual : MonoBehaviour
{

    public InteractionManager imr;
    public TextMeshProUGUI StartRitualUIText; 
    int ritualStarted = 0;
    [SerializeField] private Animator waterColorTransition;
    //[SerializeField] private Animator cameraBlackAndWhiteTransition;
    [SerializeField] private Animator sunColorTransition;
    [SerializeField] private Animator postEffectTranstion;

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
            if(ritualStarted == 0)
            {
                if (imr.litCandles == 5) 
                {
                StartRitualUIText.gameObject.SetActive(true);
                    if (Input.GetKey(KeyCode.E))
                    {
                    print("Ritual Starts");
                    StartRitualUIText.gameObject.SetActive(false);
                    ritualStarted++;
                    waterColorTransition.SetBool("waterColorChange", true);
                    //cameraBlackAndWhiteTransition.SetBool("cameraColorChange", true);
                    sunColorTransition.SetBool("sunColorChange", true);
                    postEffectTranstion.SetBool("postEffectChange", true);
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

