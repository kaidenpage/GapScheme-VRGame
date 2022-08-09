using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    public WinLose WinLoseScript;
    public GameObject player;
    public AudioSource tackle;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            tackle.Play();
            WinLoseScript.WinLevel();
        }
    }
}
