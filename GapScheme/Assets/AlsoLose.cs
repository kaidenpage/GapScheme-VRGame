using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlsoLose : MonoBehaviour
{
    public WinLose WinLoseScript;
    public GameObject player;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            WinLoseScript.LoseLevel();
        }
    }
}
