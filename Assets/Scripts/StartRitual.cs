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
    [SerializeField] private Animator sunColorTransition;
    [SerializeField] private Animator postEffectTransition;
    [SerializeField] private Animator paintingsPlaneTransition;    

    public AudioSource demonicWhisperingSource;
    public AudioClip demonicWhisperingClip;

    public GameObject whisperingLoopPlayer;

    void Start()
    {
       StartRitualUIText.gameObject.SetActive(false);
       whisperingLoopPlayer.SetActive(false);        
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
                    demonicWhisperingSource.PlayOneShot(demonicWhisperingClip);
                    StartRitualUIText.gameObject.SetActive(false);
                    ritualStarted++;
                    waterColorTransition.SetBool("waterColorChange", true);
                    sunColorTransition.SetBool("sunColorChange", true);
                    postEffectTransition.SetBool("postEffectChange", true);
                    paintingsPlaneTransition.SetBool("planePositionChange", true);
                    StartCoroutine(EnableWhisperingLoop());
                    }
                }
            }
        }

        void OnTriggerExit(Collider other)
        {       
            StartRitualUIText.gameObject.SetActive(false);       
        }
    }

    IEnumerator EnableWhisperingLoop()
    {
        yield return new WaitForSeconds(8);
        whisperingLoopPlayer.SetActive(true);
    } 

}

