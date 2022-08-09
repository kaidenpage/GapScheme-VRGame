using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EditorPlayerTrigger : MonoBehaviour
{
     public WinLose WinLoseScript;
    public GameObject RB;
   
    // Update is called once per frame
    void Update()
    {
        if( RB.transform.position.x >  5 + transform.position.x)
        {
            WinLoseScript.LoseLevel();
        }


    }
}
