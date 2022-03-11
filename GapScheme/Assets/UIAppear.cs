using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIAppear : MonoBehaviour
{
    [SerializeField] private Image customImage;


    void Start()
    {
        customImage.enabled = false;
    }



    void OnTriggerEnter(Collider player)
    {
        if (player.CompareTag("Player"))
        {
            customImage.enabled = true;
            StartCoroutine(WaitForSec());

        }
     
    }

     /*void OnTriggerExit(Collider other)
     {
         if (other.CompareTag("Player"))
         {
             customImage.enabled = false;
         }
     }
     */
    

    IEnumerator WaitForSec()
    {
        yield return new WaitForSeconds(15f);

        Destroy(customImage);

    }

    
}
