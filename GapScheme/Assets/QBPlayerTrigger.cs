using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QBPlayerTrigger : MonoBehaviour
{
    public WinLose WinLoseScript;
    public GameObject QB;
   
    // Update is called once per frame
    void Update()
    {
        if( QB.transform.position.x >  5 + transform.position.x || QB.transform.position.z <  3 + transform.position.z )
        {
            WinLoseScript.LoseLevel();
        }


    }
}